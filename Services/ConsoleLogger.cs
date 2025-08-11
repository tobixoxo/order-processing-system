using OrderProcessingSystem;

public class ConsoleLogger : ILogger
{
    private static ConsoleLogger _instance;

    private static readonly object _lock = new object();

    private ConsoleLogger()
    {
    }

    public static ConsoleLogger GetInstance()
    {
        // TODO : thread safe singleton implementation
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ConsoleLogger();
                } 
            }
        }
        return _instance;
    }
    public void LogError(string message)
    {
        Console.WriteLine($"Error: {message}");
    }

    public void LogInfo(string message)
    {
        Console.WriteLine($"Info: {message}");
    }
}