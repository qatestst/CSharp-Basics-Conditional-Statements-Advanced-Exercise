namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double price = 0;

            switch (input)
            {
                case "Premiere": price = 12; break;
                case "Normal": price = 7.50;break;
                case "Discount": price = 5.00; break;
            }

            Console.WriteLine($"{rows * cols * price:F2}");
        }
    }
}