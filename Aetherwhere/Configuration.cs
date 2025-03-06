using Dalamud.Configuration;
using Dalamud.Plugin;
using System;

namespace Aetherwhere; //  Updated namespace

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;

    public bool IsConfigWindowMovable { get; set; } = true;
    public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;

    public void Save()
    {
        if (Aetherwhere.PluginInterface != null)
        {
            Aetherwhere.PluginInterface.SavePluginConfig(this);
        }
    }
}
