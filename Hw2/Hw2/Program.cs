using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Continent Europe = new Continent("Europe", 10180000, 747772117);
            Continent Asia = new Continent("Asia", 44579000, 4653031515);
            Country Georgia = new Country("Georgia", 69700, 3986889, Europe.ID);

            City Tbilisi = new City("Tbilisi", 504, 1171100, Georgia.ID);
            City Kutaisi = new City("Kutaisi", 67, 147635, Georgia.ID);
            City Rustavi = new City("Rustavi", 30, 127800, Georgia.ID);

            Europe.PrintChildren();
            Asia.PrintChildren();
            Georgia.PrintChildren();

            Georgia.ContinentID = Asia.ID;

            Asia.PrintChildren();
            Europe.PrintChildren();

            Console.ReadKey();
        }
    }
}
