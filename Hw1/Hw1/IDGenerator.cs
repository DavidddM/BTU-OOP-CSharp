using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    public static class IDGenerator
    {
        private static int id = 0;
        public static int ID
        {
            get
            {
                return id++;
            }
        }
    }
}
