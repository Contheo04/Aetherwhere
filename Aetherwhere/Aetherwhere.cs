using Dalamud.Game.Command;
using Dalamud.IoC;
using Dalamud.Plugin;
using System.IO;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using Aetherwhere.Windows;

namespace Aetherwhere;

public sealed class Aetherwhere : IDalamudPlugin
{
    [PluginService] internal static IDalamudPluginInterface PluginInterface { get; private set; } = null!;
    [PluginService] internal static ITextureProvider TextureProvider { get; private set; } = null!;
    [PluginService] internal static ICommandManager CommandManager { get; private set; } = null!;
    [PluginService] internal static IClientState ClientState { get; private set; } = null!;
    [PluginService] internal static IDataManager DataManager { get; private set; } = null!;
    [PluginService] internal static IPluginLog Log { get; private set; } = null!;

    private const string CommandName1 = "/aetherwhere";
    private const string CommandName2 = "/aw";

    public Configuration Configuration { get; init; }
    public readonly WindowSystem WindowSystem = new("Aetherwhere");

    private ConfigWindow ConfigWindow { get; init; }
    private MainWindow MainWindow { get; init; }

    public Aetherwhere()
    {
        Configuration = PluginInterface.GetPluginConfig() as Configuration ?? new Configuration();

        var goatImagePath = Path.Combine(PluginInterface.AssemblyLocation.Directory?.FullName!, "goat.png");

        ConfigWindow = new ConfigWindow(this);
        MainWindow = new MainWindow(this);

        WindowSystem.AddWindow(ConfigWindow);
        WindowSystem.AddWindow(MainWindow);

        // Register Commands
        RegisterCommands();

        // Hook UI events
        PluginInterface.UiBuilder.Draw += DrawUI;
        PluginInterface.UiBuilder.OpenConfigUi += ToggleConfigUI;
        PluginInterface.UiBuilder.OpenMainUi += ToggleMainUI;

        // Log Plugin Initialization
        Log.Information($"[{PluginInterface.Manifest.Name}] Plugin loaded successfully.");
    }

    public void Dispose()
    {
        // Remove Windows
        WindowSystem.RemoveAllWindows();

        ConfigWindow.Dispose();
        MainWindow.Dispose();

        // Unregister Commands
        UnregisterCommands();
    }

    private void RegisterCommands()
    {
        CommandManager.AddHandler(CommandName1, new CommandInfo(OnCommand)
        {
            HelpMessage = "Opens the Aetherwhere UI."
        });

        CommandManager.AddHandler(CommandName2, new CommandInfo(OnCommand)
        {
            HelpMessage = "Opens the Aetherwhere UI."
        });
    }

    private void UnregisterCommands()
    {
        CommandManager.RemoveHandler(CommandName1);
        CommandManager.RemoveHandler(CommandName2);
    }

    private void OnCommand(string command, string args) => ToggleMainUI();

    private void DrawUI() => WindowSystem.Draw();

    public void ToggleConfigUI() => ConfigWindow.Toggle();
    public void ToggleMainUI() => MainWindow.Toggle();
}
