public class AetherCurrentData
{
    public string Expansion { get; set; } // Heavensward, Stormblood, etc.
    public string Zone { get; set; } // The Ruby Sea, Azim Steppe, etc.
    public float X { get; set; }
    public float Y { get; set; }
    public bool IsCollected { get; set; } // Future feature
    public string Type { get; set; } // Exploration, Quest, etc.
    public uint QuestId { get; set; } // Quest ID (only for quest-based currents)


    public string Description { get; set; }

    public AetherCurrentData(string expansion, string zone, float x, float y, string type, string desc, uint questId = 0)
    {
        Expansion = expansion;
        Zone = zone;
        X = x;
        Y = y;
        Type = type;
        Description = desc;
        QuestId = questId;
        IsCollected = false; // Default to false
        
    }
}
