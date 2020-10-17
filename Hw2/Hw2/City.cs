using Hw2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class City: GeographicalLoc
    {
        private int _countryId = Int32.MinValue;
        public int CountryID
        {
            get => _countryId;
            set
            {
                Country country = GetByID(value) as Country;
                if (_countryId != Int32.MinValue)
                {
                    Country OldCountry = GetByID(_countryId) as Country;
                    OldCountry.DeleteChildID(ID);
                }
                country?.AddChildID(ID);
                _countryId = value;
            }
        }
        public City(string Name, ulong Area, ulong Population, int CountryID) : base(Name, Area, Population)
        {
            this.CountryID = CountryID;
        }
    }
}
