using Hw2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hw2.Abstract
{
    abstract class BaseClass
    {
        public int ID { get; set; }
        public static IList<BaseClass> objects { get; set; } = new List<BaseClass>();
        protected BaseClass()
        {
            ID = IDGenerator.ID;
            objects.Add(this);
        }
        public static BaseClass GetByID(int id)
        {
            return BaseClass.objects.FirstOrDefault(x => x.ID == id);
        }
    }
}
