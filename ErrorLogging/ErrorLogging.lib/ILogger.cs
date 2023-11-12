namespace ErrorLogging.lib
{
    public interface ILogger
    {
        void WriteMessage(LogLavel level, string message );
    }
}
