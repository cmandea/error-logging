namespace ErrorLogging.app
{
    internal class ConsoleHelper
    {
        public static int ReadNumber(string label, int maxTries, int defaultValue)
        {
            int tries = 0;
            do
            {
                Console.Write(label ?? "Number=");
                string text = Console.ReadLine();

                if (int.TryParse(text, out int result))
                {
                    return result;
                }

                Console.WriteLine($"'{text}' is not a valid numeric value, please try again...");

                tries++;

            }
            while (tries < maxTries);
            return defaultValue;
        }
        public static void PrintArray(string label, int[] array)
        {
            string commaSeparatedElements = string.Join(", ", array ?? new int[0]);
            Console.Write(label ?? "Array=");
            Console.WriteLine($"[{commaSeparatedElements}]");

        }

    }
}
