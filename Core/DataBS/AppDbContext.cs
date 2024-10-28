using Core.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataBS
{
    public class AppDbContext
    {
        static List<Country> Countries = new List<Country>();
        static List<Planet> Planets = new List<Planet>();

        public void CreateCountry()
        {
            Console.Write("Enter country name: ");
            string name=Console.ReadLine();

            bool f = false;
            double area = 0;
            int num = 0;
            do
            {
                Console.Write("Enter country area: ");
                if(double.TryParse(Console.ReadLine(), out area))
                {
                    Console.WriteLine("Area is entered.");
                    f= true;
                }
                else
                {
                    Console.WriteLine("Please, enter correct number of area");
                }

            } while (!f);

            Console.Write("Enter country anthem: ");
            string anthem = Console.ReadLine();

            Console.Write("Enter country region by numbers(1.Avrupa, 2.Asiya, 3.Amerika): ");
            
            bool f1=false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 3)
                {
                    Console.WriteLine("Region of country is entered.");
                    f1= true;
                }
                else
                {
                    Console.WriteLine("Please, enter only 1, 2 or 3 numbers");
                }
            }while(!f1);

            Country country = new Country(name, area, anthem, (Region)num);

            Countries.Add(country);

        }

        public void UpdateCountry(int id)
        {

            foreach (Country country in Countries) 
            { 
                if(country.Id == id)
                {
                    Console.Write("Add new name of country: ");
                    string name= Console.ReadLine();
                    country.Name = name;
                    Console.WriteLine("Name of country is updated:");
                    Console.WriteLine($"Name: {country.Name}, Area: {country.Area}, Anthem: {country.Anthem}, Region: {country.region}");
                    break;
                }
            }
        }

        public void RemoveCountry(int id)
        {
            List<Country> newcountries = new List<Country>();
            foreach (Country item in Countries)
            {
                if (item.Id != id)
                {
                    newcountries.Add(item);
                }
                
            }
            Countries=newcountries;
            Console.WriteLine("Counrty is removed.");
        }

        public void GetAllCountries()
        {
            foreach(Country country in Countries)
            {
                Console.WriteLine($"Name: {country.Name}, Area: {country.Area}, Anthem: {country.Anthem}, Region: {country.region}");
            }
        }

        public void GetCountryByRegion()
        {
            Console.WriteLine("Enter region that you want to get by number (1.Avrupa, 2.Asiya, 3.Amerika)");
            bool f1 = false;
            int num = 0;
            
            do
            {
                if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 3)
                {
                    f1 = true;
                }
                else
                {
                    Console.WriteLine("Please, enter only 1, 2 or 3 numbers");
                }
            } while (!f1);

            foreach (Country country in Countries) 
            {
                if (country.region == (Region)num)
                {
                    Console.WriteLine($"Name: {country.Name}, Area: {country.Area}, Anthem: {country.Anthem}, Region: {country.region}");
                }
            }
        }

        public void Getcountry(int id)
        {
            foreach (Country country in Countries)
            {
                if(country.Id == id)
                {
                    Console.WriteLine($"Name: {country.Name}, Area: {country.Area}, Anthem: {country.Anthem}, Region: {country.region}");
                }
            }
        }



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void CreatePlanet()
        {
            Console.Write("Enter planet name: ");
            string name = Console.ReadLine();

            bool f = false;
            double area = 0;
            do
            {
                Console.Write("Enter planet area: ");
                if (double.TryParse(Console.ReadLine(), out area))
                {
                    Console.WriteLine("Area is entered.");
                    f = true;
                }
                else
                {
                    Console.WriteLine("Please, enter correct number of area");
                }

            } while (!f);

            Planet planet =new Planet(name,area);

            Planets.Add(planet);
        }

        public void UpdatePlanet(int id)
        {
            foreach (Planet planet in Planets)
            {
                if (planet.Id == id)
                {
                    Console.Write("Add new name of planet: ");
                    string name = Console.ReadLine();
                    planet.Name = name;
                    Console.WriteLine("Name of planet is updated:");
                    Console.WriteLine($"Name: {planet.Name}, Area: {planet.Area}");
                    break;
                }
            }
        }

        public void RemovePlanet(int id)
        {
            List<Planet> newplanets = new List<Planet>();
            foreach (Planet item in Planets)
            {
                if (item.Id != id)
                {
                    newplanets.Add(item);
                }

            }
            Planets = newplanets;
            Console.WriteLine("Planet is removed.");
        }

        public void GetAllPlanets()
        {
            foreach (Planet item in Planets)
            {
                Console.WriteLine($"Name: {item.Name}, Area: {item.Area}");
            }
        }

        public void Getplanet(string name)
        {
            foreach (Planet planet in Planets)
            {
                if (planet.Name == name)
                {
                    Console.WriteLine($"Name: {planet.Name}, Area: {planet.Area}");
                }
            }
        }




    }

    
}
