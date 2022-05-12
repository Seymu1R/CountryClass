using HomeWorkCountry.Models;
using System;

namespace HomeWorkCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            City city = new City("Sheki", 50000);
            City city1 = new City("Astara", 100000);
            City city2 = new City("Baku", 5000000);
            city.FindAllByPopulation(40000, 4000000, city, city1, city2);
            Country Azerbaijan = new Country("Azerbaijan");
            Azerbaijan.AddCity(city2);
            Azerbaijan.AddCity(city);
            Azerbaijan.AddCity(city1);
            Azerbaijan.TotalPopulation();
            Console.WriteLine("\n");
            City city3 = new City("Rome", 2783809);
            City city4 = new City("Milan", 1397715);
            City city5 = new City("Turin", 8481965);
            city.FindAllByPopulation(40000, 4000000, city3, city4, city5);
            Country Italy = new Country("Italy");
            Italy.AddCity(city3);
            Italy.AddCity(city4);
            Italy.AddCity(city5);
            Italy.TotalPopulation();

        }
    }
}
