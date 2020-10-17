using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2.Utils
{
    public static class IDGenerator
    {
        private static int id = 1;
        public static int ID
        {
            get
            {
                return id++;
            }
        }
    }
}
