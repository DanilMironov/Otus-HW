using PluginInterface;

namespace SecondPlugin;

/// <summary>
/// Плагин с ошибкой при загрузке
/// </summary>
public class SecondPlugin : IPlugin
{
    public void Load()
    {
        throw new Exception("SecondPlugin threw an exception");
    }
}