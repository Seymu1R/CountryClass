using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkCountry.Models
{
    class City
    {
        public string Name { get; set; }
        public  int Population { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public  void FindAllByPopulation(int min, int max,City city1, City city2, City city3) {
            List<City> CityList = new List<City>();
            while (min < city1.Population && city1.Population < max)
            {
                CityList.Add(city1);
                break;
            }
            while (min < city2.Population && city2.Population < max)
            {
                CityList.Add(city2);
                break;
            }

            while (min < city3.Population && city3.Population < max)
            {
                CityList.Add(city3);
                break;
            }
           
            foreach (var item in CityList)
            {
                Console.WriteLine($" Given range be exist Cities  --  {item.Name} {item.Population}");
            }
        }
    }
}
