namespace ErrorLogging.lib
{
    public class DebugWindowLogger : ILogger
    {
         public void WriteMessage(LogLavel level, string message)
        {
            System.Diagnostics.Debug.WriteLine($"[{level}]-[{message}]");
        }
    }
}
