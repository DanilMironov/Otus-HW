using System.Collections.Concurrent;
using System.Reflection;
using PluginInterface;

namespace MainLoader;

public class Program
{
    private const string _absolutePath =
        "/Users/danilmironov/Desktop/repos/otus/Homework/HW_4/Otus-HW/Spacebattle/Dlls";

    private const string _patternToGetFiles = "*.dll";

    private static bool _needToStop = false;

    public static void Main()
    {
        var pluginsToLoad = new ConcurrentQueue<IPlugin>();
        
        var getPLuginsThread = new Thread(() => GetPlugins(pluginsToLoad, _absolutePath));
        var loadPluginsThread = new Thread(() => LoadPlugins(pluginsToLoad));
        
        getPLuginsThread.Start();
        loadPluginsThread.Start();
        
        getPLuginsThread.Join();
        loadPluginsThread.Join();
    }

    private static void GetPlugins(ConcurrentQueue<IPlugin> queue, string folderPath)
    {
        try
        {
            var files = Directory.GetFiles(folderPath, _patternToGetFiles);
            foreach (var file in files)
            {
                var assembly = Assembly.LoadFrom(file);
                var type = assembly?.GetTypes()?
                    .FirstOrDefault(x => typeof(IPlugin).IsAssignableFrom(x));
                if (type is null)
                {
                    continue;
                }
                queue.Enqueue(Activator.CreateInstance(type) as IPlugin);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"!!!!!Exception occured: {ex.Message}");
            throw;
        }
        finally
        {
            _needToStop = true;
        }
    }

    private static void LoadPlugins(ConcurrentQueue<IPlugin> plugins)
    {
        var errors = new ConcurrentQueue<IPlugin>();

        while (!plugins.IsEmpty)
        {
            var count = plugins.Count;

            IPlugin plugin;
            
            while (plugins.TryDequeue(out plugin) || !_needToStop)
            {
                try
                {
                    plugin.Load();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occured while loading the plugin: PLugin - {plugin}, exception - {ex.Message}");
                    errors.Enqueue(plugin);
                }
            }
            if (errors.Count == plugins.Count)
                break;
            plugins = errors;
            errors = new ConcurrentQueue<IPlugin>();
        }
    }
}