using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            var list = new List<T>(items);            
            return list ;
        }
    }
}
