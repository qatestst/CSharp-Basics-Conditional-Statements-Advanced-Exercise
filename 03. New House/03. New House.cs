namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            double flowerCount = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;

            switch(flowerType) 
            {
                case "Roses": if (flowerCount > 80) price = 5 * 0.9; else price = 5; break;
                case "Dahlias": if (flowerCount > 90) price = 3.8 * 0.85; else price = 3.80; break;
                case "Tulips": if (flowerCount > 80) price = 2.8 * 0.85; else price = 2.8; break;
                case "Narcissus": if (flowerCount < 120) price = 3 * 1.15; else price = 3; break;
                case "Gladiolus": if (flowerCount < 80) price = 2.5 * 1.20; else price = 2.5; break;
            }

            double totalPrice = flowerCount * price;

            if ((budget - totalPrice) >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");

            }
        }
    }
}