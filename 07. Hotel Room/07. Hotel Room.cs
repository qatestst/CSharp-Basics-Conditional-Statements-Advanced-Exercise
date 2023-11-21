namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (count > 14)
                    {
                        studioPrice = studioPrice * 0.7;
                        apartmentPrice = apartmentPrice * 0.9;
                        Console.WriteLine($"Apartment: {(apartmentPrice * count):f2} lv.");
                        Console.WriteLine($"Studio: {(studioPrice * count):f2} lv.");
                    }
                    else if (count > 7)
                    {
                        studioPrice = studioPrice * 0.95;
                        Console.WriteLine($"Apartment: {(apartmentPrice * count):f2} lv.");
                        Console.WriteLine($"Studio: {(studioPrice * count):f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Apartment: {(apartmentPrice * count):f2} lv.");
                        Console.WriteLine($"Studio: {(studioPrice * count):f2} lv.");
                    }
                    break;


                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (count > 14)
                    {
                        studioPrice = studioPrice * 0.8;
                        apartmentPrice = apartmentPrice * 0.9;
                        Console.WriteLine($"Apartment: {(apartmentPrice * count):f2} lv.");
                        Console.WriteLine($"Studio: {(studioPrice * count):f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Apartment: {(apartmentPrice * count):f2} lv.");
                        Console.WriteLine($"Studio: {(studioPrice * count):f2} lv.");
                    }
                    break;


                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    if (count > 14)
                    {
                        apartmentPrice = apartmentPrice * 0.9;
                        Console.WriteLine($"Apartment: {(apartmentPrice * count):f2} lv.");
                        Console.WriteLine($"Studio: {(studioPrice * count):f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Apartment: {(apartmentPrice * count):f2} lv.");
                        Console.WriteLine($"Studio: {(studioPrice * count):f2} lv.");
                    }
                    break;

            }

        }
    }
}