using HomeWorkCountry.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkCountry
{
    class Country
    {
        List<City> CountryGeneraly = new List<City>();
        public string Name { get; set; }
        public int totalPopulation;
        
        public Country( string name )
        {
            Name = name;
            
        }
        public  void AddCity(City city) {
            CountryGeneraly.Add(city);
        }
        public void TotalPopulation()
        {
            
            foreach (var item in CountryGeneraly)
            {
                totalPopulation +=  item.Population;               
                
            }
            Console.WriteLine($"Generaly population of Country -- { totalPopulation}");
        }
        
    }
}
