namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //summer , winter
            string destination = ""; //Bulgaria , Balkans , Europe
            string holidayType = ""; //camp ot hotel
            double spentMoney = 0;

            if (budget <= 100) { destination = "Bulgaria"; }
            else if (budget > 100 && budget <= 1000) { destination = "Balkans"; }
            else if (budget > 1000) { destination = "Europe"; }

            if (season == "summer" && destination == "Bulgaria")
            {
                holidayType = "Camp";
                spentMoney = budget * 0.3;
            }
            else if (season == "winter" && destination == "Bulgaria")
            {
                holidayType = "Hotel";
                spentMoney = budget * 0.7;
            }
            else if (season == "summer" && destination == "Balkans")
            {
                holidayType = "Camp";
                spentMoney = budget * 0.4;
            }
            else if (season == "winter" && destination == "Balkans")
            {
                holidayType = "Hotel";
                spentMoney = budget * 0.8;
            }
            else if (season == "summer" && destination == "Europe" || season == "winter" && destination == "Europe")
            {
                holidayType = "Hotel";
                spentMoney = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {spentMoney:F2}");
        }
    }
}