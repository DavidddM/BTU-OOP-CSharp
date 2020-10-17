using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2.Interfaces
{
    interface IParent
    {
        void AddChildID(int id);
        void DeleteChildID(int id);
        void PrintChildren();

    }
}
