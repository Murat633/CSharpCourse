using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<String>("ahmet","mehmet","selman");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
