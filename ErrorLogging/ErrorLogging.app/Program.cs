using ErrorLogging.lib;

namespace ErrorLogging.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //app startup > initializare logger
            ApplicationLog.Initialize(new ConsoleLogger());
            //app codebase
            int n = ConsoleHelper.ReadNumber("Number of elements(array size):", 3, 0);
            if (n <= 0)
            {
                ApplicationLog.WriteMessage(LogLavel.High, $"Array size ({n}) is negative or zero");
                return;
            }
            int[] array = new int[n];
            for (int i = 0; i< array.Length; i++)
            {
                int element=ConsoleHelper.ReadNumber($"Element at index {i}=", 3, 0);
                if (element <= 0) 
                {
                    ApplicationLog.WriteMessage(LogLavel.Warning, $"Element at index {i} has negative value:{element}");
                    return;
                }
                array[i] = element;
                ConsoleHelper.PrintArray("Array is :", array);

            }
            
            Console.WriteLine("Hello, World!");
        }
    }
}