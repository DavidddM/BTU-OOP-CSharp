using Hw2.Abstract;
using Hw2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Continent: GeographicalLoc, IParent
    {
        private IList<int> Countries_One2many { get; set; }
        public Continent(string Name, ulong Area, ulong Population): base(Name, Area, Population)
        {
            Countries_One2many = new List<int>();
        }
        public void AddChildID(int id)
        {
            Countries_One2many.Add(id);
        }
        public void DeleteChildID(int id)
        {
            Countries_One2many.Remove(id);
        }
        public void PrintChildren()
        {
            Console.WriteLine($"Countries of {this.Name}:");
            if (Countries_One2many.Count == 0)
            {
                Console.WriteLine($"\tCurrently there are no countries in {this.Name}");
            }
            else foreach (int key in Countries_One2many)
            {
                Console.WriteLine($"\t{((Country)GetByID(key))?.Name}");
            }
        }
    }
}
