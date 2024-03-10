namespace PluginInterface;

/// <summary>
/// Интерфейс плагина
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Производит загрузку плагина
    /// </summary>
    void Load();
}