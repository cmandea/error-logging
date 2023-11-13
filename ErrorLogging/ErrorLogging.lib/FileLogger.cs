namespace ErrorLogging.lib
{
    public class FileLogger : ILogger
    {

        public FileLogger(string directory) 
        {
            if (directory is null)
            {
                throw new ArgumentNullException(nameof(directory));
            }
            if (string.IsNullOrEmpty(directory))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(directory));
            }
            if (!System.IO.Path.Exists(directory))
            { 
            throw new DirectoryNotFoundException($"Directory '{directory}' was not found");
            }
            Directory = directory;
        }
        public string Directory {  get; }
        public void WriteMessage(LogLavel level, string message)
        {
            string fileName = $"Log_{DateTime.Today:yyyy-MM-dd}.txt";
            string filePath = Path.Combine(Directory,fileName);
            string content = $"[{level}]-[{message}]" + Environment.NewLine;//Environment.NewLine echivalent \n
            File.AppendAllText(filePath, content);
                
        }
    }
}
