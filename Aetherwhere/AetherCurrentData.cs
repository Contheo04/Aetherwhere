public class AetherCurrentData
{
    public string Expansion { get; set; } // Heavensward, Stormblood, etc.
    public string Zone { get; set; } // The Ruby Sea, Azim Steppe, etc.
    public float X { get; set; }
    public float Y { get; set; }
    public bool IsCollected { get; set; } // Future feature
    public string Type { get; set; } // Exploration, Quest, etc.

    public string Description { get; set; }

    public AetherCurrentData(string expansion, string zone, float x, float y, string type, string desc)
    {
        Expansion = expansion;
        Zone = zone;
        X = x;
        Y = y;
        IsCollected = false; // Default to false
        Type = type;
        Description = desc;
    }
}
