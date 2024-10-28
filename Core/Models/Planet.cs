using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Planet
    {
        public Planet(string name, double area)
        {
            Name = name;
            Area = area;
        }

        private static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }

    }
}
