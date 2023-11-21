namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine(); // "room for one person", "apartment", "president apartment"
            string assessment = Console.ReadLine(); // "positive" or "negative"

            int nights = days - 1;
            double onePersonRoomPrice = 18; // per night
            double apartmentPrice = 25; // per night
            double presidentApartmentPrice = 35; // per night

            double totalcost = 0;


            switch (roomType)
            {
                case "room for one person":
                    if (assessment == "positive")
                    {
                        totalcost = nights * onePersonRoomPrice * 1.25;
                        Console.WriteLine($"{totalcost:f2}");
                    }
                    else if (assessment == "negative")
                    {
                        totalcost = nights * onePersonRoomPrice * 0.9;
                        Console.WriteLine($"{totalcost:f2}");
                    }
                    break;

                case "apartment":
                    if (days > 15)
                    {
                        apartmentPrice = apartmentPrice * 0.5;
                        if (assessment == "positive")
                        {
                            totalcost = nights * apartmentPrice * 1.25;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                        else if (assessment == "negative")
                        {
                            totalcost = nights * apartmentPrice * 0.9;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        apartmentPrice = apartmentPrice * 0.65;
                        if (assessment == "positive")
                        {
                            totalcost = nights * apartmentPrice * 1.25;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                        else if (assessment == "negative")
                        {
                            totalcost = nights * apartmentPrice * 0.9;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                    }
                    else if (days < 10)
                    {
                        apartmentPrice = apartmentPrice * 0.7;
                        if (assessment == "positive")
                        {
                            totalcost = nights * apartmentPrice * 1.25;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                        else if (assessment == "negative")
                        {
                            totalcost = nights * apartmentPrice * 0.9;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                    }
                    break;

                case "president apartment":
                    if (days > 15)
                    {
                        presidentApartmentPrice = presidentApartmentPrice * 0.8;
                        if (assessment == "positive")
                        {
                            totalcost = nights * presidentApartmentPrice * 1.25;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                        else if (assessment == "negative")
                        {
                            totalcost = nights * presidentApartmentPrice * 0.9;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        presidentApartmentPrice = presidentApartmentPrice * 0.85;
                        if (assessment == "positive")
                        {
                            totalcost = nights * presidentApartmentPrice * 1.25;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                        else if (assessment == "negative")
                        {
                            totalcost = nights * presidentApartmentPrice * 0.9;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                    }
                    else if (days < 10)
                    {
                        presidentApartmentPrice = presidentApartmentPrice * 0.9;
                        if (assessment == "positive")
                        {
                            totalcost = nights * presidentApartmentPrice * 1.25;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                        else if (assessment == "negative")
                        {
                            totalcost = nights * presidentApartmentPrice * 0.9;
                            Console.WriteLine($"{totalcost:f2}");
                        }
                    }
                    break;

            }

        }
    }
}