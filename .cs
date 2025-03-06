namespace Aetherwhere;

public class AetherCurrentData
{
    public string Zone { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public bool IsCollected { get; set; } = false; // (Later) Track collection status

    public AetherCurrentData(string zone, float x, float y)
    {
        Zone = zone;
        X = x;
        Y = y;
    }
}
