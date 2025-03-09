using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Dalamud.Interface;
using Dalamud.Interface.Utility;
using Dalamud.Interface.Utility.Raii;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using ImGuiNET;
using FFXIVClientStructs.FFXIV.Client.Game;

namespace Aetherwhere.Windows;

public class MainWindow : Window, IDisposable
{
    private readonly Aetherwhere plugin;
    private int SelectedExpansion = 0;
    private int SelectedArea = 0;

    private readonly Dictionary<string, string[]> ExpansionAreas = new()
    {
        { "Heavensward", new[] { "Coerthas Western Highlands", "The Dravanian Forelands", "The Dravanian Hinterlands", "The Churning Mists", "The Sea of Clouds", "Azys Lla" } },
        { "Stormblood", new[] { "The Fringes", "The Ruby Sea", "The Peaks", "Yanxia", "The Lochs", "The Azim Steppe" } },
        { "Shadowbringers", new[] { "Lakeland", "Amh Araeng", "Il Mheg", "Kholusia", "The Rak'tika Greatwood", "The Tempest" } },
        { "Endwalker", new[] { "Labyrinthos", "Thavnair", "Garlemald", "Mare Lamentorum", "Elpis", "Ultima Thule" } }
    };

    public MainWindow(Aetherwhere plugin)
        : base("Aetherwhere##Aetherwhere", ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse)
    {
        this.plugin = plugin;
        SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(450, 350),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };
    }

    public void Dispose() { }

    public override void Draw()
    {
        // Expansion Selection
        ImGui.Text("Select an Expansion:");
        var expansions = ExpansionAreas.Keys.ToArray();
        ImGui.Combo("##expansionSelector", ref SelectedExpansion, expansions, expansions.Length);

        // Separator for better UI clarity
        ImGuiHelpers.ScaledDummy(5);
        ImGui.Separator();
        ImGuiHelpers.ScaledDummy(5);

        // Get areas for selected expansion
        var selectedExpansionName = expansions[SelectedExpansion];
        var areas = ExpansionAreas[selectedExpansionName];

        // Area Selection
        ImGui.Text("Select an Area:");
        ImGui.Combo("##areaSelector", ref SelectedArea, areas, areas.Length);

        ImGuiHelpers.ScaledDummy(5);
        ImGui.Separator();
        ImGuiHelpers.ScaledDummy(5);

        // Table for Aether Currents
        using var table = ImRaii.Table("##aetherTable", 4, ImGuiTableFlags.Borders | ImGuiTableFlags.RowBg);
        if (table.Success)
        {
            ImGui.TableSetupColumn("Collected", ImGuiTableColumnFlags.WidthFixed, 100);
            ImGui.TableSetupColumn("Type", ImGuiTableColumnFlags.WidthFixed, 100);
            ImGui.TableSetupColumn("Location", ImGuiTableColumnFlags.WidthStretch);
            ImGui.TableSetupColumn("Coords", ImGuiTableColumnFlags.WidthFixed, 120);
            ImGui.TableHeadersRow();

            // Filter and display Aether Currents based on selected expansion and area
            foreach (var current in AetherCurrentList.aetherCurrents.Where(a =>
                a.Expansion == selectedExpansionName && a.Zone == areas[SelectedArea]))
            {
                float rowHeight = 25f;

                // Determine collection status (if quest-based, check quest completion)
                bool isCollected = (current.Type == "Quest") ? IsQuestCompleted(current.QuestId) : false;

                // Column 1: Collected Status (✓ or ✗)
                ImGui.TableNextColumn();
                ImGui.SetCursorPosY(ImGui.GetCursorPosY() + (rowHeight * 0.25f));
                using (ImRaii.PushFont(UiBuilder.IconFont))
                {
                    ImGui.TextUnformatted(isCollected ? FontAwesomeIcon.Check.ToIconString() : FontAwesomeIcon.Times.ToIconString());
                }

                // Column 2: Type (Exploration or Quest)
                ImGui.TableNextColumn();
                ImGui.SetCursorPosY(ImGui.GetCursorPosY() + (rowHeight * 0.25f));
                ImGui.TextUnformatted(current.Type);

                // Column 3: Location Name (Quest Name if Quest)
                ImGui.TableNextColumn();
                ImGui.SetCursorPosY(ImGui.GetCursorPosY() + (rowHeight * 0.25f));
                ImGui.TextUnformatted(current.Type == "Quest" ? current.Description : current.Zone);

                // Column 4: Coordinates (Clickable)
                ImGui.TableNextColumn();
                ImGui.SetCursorPosY(ImGui.GetCursorPosY() + (rowHeight * 0.25f));
                if (ImGui.Selectable($"{current.X}, {current.Y}##{current.Zone}"))
                {
                    // Future: Add functionality to set map marker
                }

                ImGui.TableNextRow();
            }
        }
    }

    private bool IsQuestCompleted(uint questId)
    {
        if (questId == 0)
            return false; // If no quest ID, it's an exploration current

        return QuestManager.IsQuestComplete(questId);
    }
}
