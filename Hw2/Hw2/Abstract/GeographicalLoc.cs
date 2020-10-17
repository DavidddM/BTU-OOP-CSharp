using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2.Abstract
{
    abstract class GeographicalLoc: BaseClass
    {
        public string Name { get; set; }
        public ulong Area { get; set; }
        public ulong Population { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}\nArea: {this.Area}\nPopulation: {this.Population}";
        }

        public GeographicalLoc(string Name, ulong Area, ulong Population)
        {
            this.Name = Name;
            this.Area = Area;
            this.Population = Population;
        }
    }
}
