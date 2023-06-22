namespace ConsoleApp85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            int lengthName = 0;

            Console.Write("Введите имя:");
            name = Console.ReadLine();
            Console.Write("Введите символ, который обведёт ваше имя в рамку:");
            symbol = Console.ReadLine();
            lengthName = name.Length + symbol.Length + symbol.Length;

            for (int i = 0; i < lengthName; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
            Console.WriteLine(symbol + name + symbol);

            for (int i = 0; i < lengthName; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}