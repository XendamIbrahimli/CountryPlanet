using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Country
    {
        public Country(string name, double area, string anthem, Region region)
        {
            Name = name;
            Area = area;
            Anthem = anthem;
            this.region = region;

            _id++;
            Id= _id;
        }

        private static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }
        public Region region { get; set; }

        public string ShowInfo()
        {
            return $"Country ID: {Id}, Country Name: {Name}, Area: {Area}, Anthem: {Anthem}, Region: {region}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
