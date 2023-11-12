namespace ErrorLogging.lib
{
    public class ConsoleLogger:ILogger
    {
       public void WriteMessage(LogLavel level, string message)
        {
            Console.WriteLine($"[{level}]-[{message}]");
        }
    }
}
