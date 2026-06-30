using System;
using System.Collections.Generic;
using System.Linq;
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

    internal class Dealership
    {
        static Dictionary<int, Car> cars = new()
        {
            {1, new Car("4X4", "Mistubishi", 50000.50) },
            {2, new Car("Sedan", "Honda", 30000.00) },
            {3, new Car("Hatch", "Volkswagen", 20000.00) },
            {4,new Car ("SUV", "Volkswagen", 20000.00) }
        };
        public void AddCar(string model, string brand, double price)
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
        public static void Executar()
        {
            Console.WriteLine("Welcome to CarShop");
            Console.WriteLine("Would you like to add a car to our DataBase? - 1\nWould you like to look what cars we have? - 2\n Are you looking for a specifc car? - 3");
            Dealership.ListCars();
        }
    }
}
