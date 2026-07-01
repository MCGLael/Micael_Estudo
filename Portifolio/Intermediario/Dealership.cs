using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio.Intermediario
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public Car(string model, string brand, double price)
        {
            Model = model;
            Brand = brand;
            Price = price;
        }
    }

    class Dealership
    {
        static Dictionary<int, Car> cars = new()
        {
            {1, new Car("4X4", "Mitsubishi", 50000.50) },
            {2, new Car("Sedan", "Honda", 30000.00) },
            {3, new Car("Hatch", "Volkswagen", 20000.00) },
            {4,new Car ("SUV", "Volkswagen", 20000.00) }
        };
        
        public static void AddCar(string model, string brand, double price)
        {
            int key = cars.Count == 0 ? 1: cars.Last().Key+1;// Get the next key based on the last key in the dictionary
            cars.Add(key, new Car(model, brand, price));
        }
        public static void ListCars()
        {
            foreach(var (key, car) in cars)
            {
                Console.WriteLine($"ID: {key} -- Model: {car.Model} -- Brand: {car.Brand} -- Price: {car.Price}");
            }
        }
        public static void SearchCar(string brand)
        {
            brand = brand.ToLower();
            bool found = false;
            foreach (var (key, car) in cars)
            {
                if (brand == car.Brand.ToLower())
                {

                    Console.WriteLine($"ID: {key} -- Model: {car.Model} -- Brand: {car.Brand} -- Price: {car.Price}");
                    found = true;
                }
               

            }
            if (!found)
            {
                Console.WriteLine($"No cars found with the brand {brand}");

            }

        }
        public static void choice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("inserting a New Car...");
                    Console.WriteLine("Please insert the Model of the car: ");
                    string model = Console.ReadLine();
                    Console.WriteLine("Please insert the Brand of the car: ");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Please insert the Price of the car: ");
                    if (!Double.TryParse(Console.ReadLine(), out double price)) { Console.WriteLine("Invalid Price"); return; }
                    Dealership.AddCar(model, brand, price);
                    Console.WriteLine("Car added successfully!");
                    break;
                case 2:
                    Console.WriteLine("Listing all cars");
                    ListCars();
                    break;
                case 3:
                    Console.WriteLine("Inser the model of the car");
                    string mod = Console.ReadLine();
                    if(mod == null) { Console.WriteLine("Invalid Model"); return; }
                    mod.ToLower();
                    SearchCar(mod);
                    break;
                    case 4:
                        Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }
        }
        public static void Executar()
        {
            Console.WriteLine("Welcome to CarShop");
            bool exit = false;
            while (exit == false)
            {

                Console.WriteLine("Would you like to add a car to our DataBase? - 1\nWould you like to look what cars we have? - 2\nAre you looking for a specifc car? - 3\nExit - 4");
                int.TryParse(Console.ReadLine(), out int choice);
                if (choice == 4)
                {
                    exit = true;
                }
                Dealership.choice(choice);
            }
        }
    }
}
