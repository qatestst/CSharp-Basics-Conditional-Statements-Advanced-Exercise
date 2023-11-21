namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); //Бюджет на групата – цяло число в интервала [1…8000]
            string season = Console.ReadLine(); //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            double fishermenCount = double.Parse(Console.ReadLine()); //•	Брой рибари – цяло число в интервала [4…18]
            double rentPrice = 0;
            


            if (fishermenCount % 2 != 0)
            {
                switch (season)
                {
                    case "Autumn":
                    case "Summer": rentPrice = 4200; if (fishermenCount <= 6) rentPrice *= 0.9; else if (fishermenCount > 7 && fishermenCount <= 11) rentPrice *= 0.85; else if (fishermenCount >= 12) rentPrice *= 0.75; break;
                    case "Spring": rentPrice = 3000; if (fishermenCount <= 6) rentPrice *= 0.9; else if (fishermenCount > 7 && fishermenCount <= 11) rentPrice *= 0.85; else if (fishermenCount >= 12) rentPrice *= 0.75; break;
                    case "Winter": rentPrice = 2600; if (fishermenCount <= 6) rentPrice *= 0.9; else if (fishermenCount > 7 && fishermenCount <= 11) rentPrice *= 0.85; else if (fishermenCount >= 12) rentPrice *= 0.75; break;

                }
            }
            else if (fishermenCount %2 == 0) 
            {
                switch (season)
                {
                    case "Autumn": rentPrice = 4200; if (fishermenCount <= 6) rentPrice *= 0.9; else if (fishermenCount > 7 && fishermenCount <= 11) rentPrice *= 0.85; else if (fishermenCount >= 12) rentPrice *= 0.75;
                        break;

                    case "Summer": rentPrice = 4200; if (fishermenCount <= 6) rentPrice *= 0.9; else if (fishermenCount > 7 && fishermenCount <= 11) rentPrice *= 0.85; else if (fishermenCount >= 12) rentPrice *= 0.75;
                        rentPrice *= 0.95; break;

                    case "Spring": rentPrice = 3000; if (fishermenCount <= 6) rentPrice *= 0.9; else if (fishermenCount > 7 && fishermenCount <= 11) rentPrice *= 0.85; else if (fishermenCount >= 12) rentPrice *= 0.75;
                        rentPrice *= 0.95; break;

                    case "Winter": rentPrice = 2600; if (fishermenCount <= 6) rentPrice *= 0.9; else if (fishermenCount > 7 && fishermenCount <= 11) rentPrice *= 0.85; else if (fishermenCount >= 12) rentPrice *= 0.75;
                        rentPrice *= 0.95; break;

                }

            }
            if (budget < 0)
            { budget = 0; }
            
            if ((budget - rentPrice) >= 0)
            {
                Console.WriteLine($"Yes! You have {budget - rentPrice:F2} leva left.");
            }   
            else
            { 
                  Console.WriteLine($"Not enough money! You need {rentPrice-budget:F2} leva.");
            }

        }
    }
}