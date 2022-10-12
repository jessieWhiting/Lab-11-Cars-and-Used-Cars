using System.Security.Cryptography.X509Certificates;

namespace Lab_11_Cars_and_Used_Cars
{
    class Program
    {
        public static void Main()
        {
            bool goOn = true;
            while (true)
            {


                //since I have overridden string, I can do the following:
                Console.WriteLine("Vehicle Inventory:");
                Console.WriteLine("=====================================================================================================================");
                Console.WriteLine("=====================================================================================================================");


                Car c = new Car("Mitsubishi\t", "Endeavor\t", 2005, 4060.00m);
                List<Car> carsInventory = new List<Car>();
                carsInventory.Add(c);
                carsInventory.Add(new Car("Kia\t\t", "Carnival\t", 2023, 32900.00m));
                carsInventory.Add(new Car("Discovery\t", "Land Rover\t", 2023, 58400.00m));
                carsInventory.Add(new Car("Mercedes\t", "A-Class\t", 2022, 33950.00m));
                carsInventory.Add(new UsedCar("Subaru\t\t", "Forester\t", 2011, 8627.00m, 103472, "Used"));
                carsInventory.Add(new UsedCar("Hummer\t\t", "H1\t\t", 1992, 53831.00m, 213005, "Used"));
                carsInventory.Add(new UsedCar("Shelby\t\t", "Cobra\t\t", 1966, 101000000.00m, 41000, "Used"));


                int index = 1;
                foreach (Car car in carsInventory)
                {

                    Console.WriteLine(index + " :" + car);
                    index++;
                }
                Console.WriteLine("=====================================================================================================================");
                Console.WriteLine(" Select a vehicle by number to purchase.");
                Console.WriteLine("=====================================================================================================================");
                string input = Console.ReadLine();
                int pick = int.Parse(input) - 1;

                Console.WriteLine("=====================================================================================================================");
                Console.WriteLine("=====================================================================================================================");
                Console.WriteLine($" Enjoy your NEW to YOU:\n {carsInventory[pick]}");
                Console.WriteLine("=====================================================================================================================");
    
                carsInventory.RemoveAt(pick);
                index = 1;
                foreach (Car car in carsInventory)
                {

                Console.WriteLine(index + " :" + car);
                index++;

                    goOn = goAgain();
            }
                Console.WriteLine("=====================================================================================================================");
                Console.WriteLine("Thank you for your purchase.");

                 static bool goAgain()
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Would you like to Purchase another vehicle? Y/N? ");

                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "y")
                    {
                        return true;
                    }
                    else if (input == "n")
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        return goAgain();
                    }
                }
            }
        }
    }
}