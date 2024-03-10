using PluginInterface;

namespace FirstPlugin;

/// <summary>
/// Плагин, который корректно загружается
/// </summary>
public class FirstPlugin : IPlugin
{
    public void Load()
    {
        Console.WriteLine("FirstPlugin was loaded correctly");
    }
}