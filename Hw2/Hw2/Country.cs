using Hw2.Abstract;
using Hw2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Country : GeographicalLoc, IParent
    {
        private int _continentId = Int32.MinValue;
        public int ContinentID
        {
            get => _continentId;
            set
            {
                Continent cont = GetByID(value) as Continent;
                if (_continentId != Int32.MinValue)
                {
                    Continent OldCont = GetByID(_continentId) as Continent;
                    OldCont.DeleteChildID(ID);
                }
                cont?.AddChildID(ID);
                _continentId = value;
            }
        }
        private IList<int> Cities_One2many { get; set; }
        public void AddChildID(int id)
        {
            Cities_One2many.Add(id);
        }
        public void DeleteChildID(int id)
        {
            Cities_One2many.Remove(id);
        }

        public void PrintChildren()
        {
            Console.WriteLine($"Cities of {this.Name}:");
            if(Cities_One2many.Count == 0)
            {
                Console.WriteLine($"\tCurrently there are no cities in {this.Name}");
            }
            else foreach (int key in Cities_One2many)
            {
                Console.WriteLine($"\t{((City)GetByID(key))?.Name}");
            }
        }

        public Country(string Name, ulong Area, ulong Population, int ContinentID) : base(Name, Area, Population)
        {
            this.ContinentID = ContinentID;
            Cities_One2many = new List<int>();
        }
    }
}
