using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            String[] cities = new string[]
            {
                "Ankara","Malatya","Adıyaman"
            };

            String[] cities2 = new string[]
            {
                "iSTANBUL","izmir","kocaeli"
            };

            cities2 = cities;

            cities[0] = "Adana";

            Console.WriteLine(cities2[0]);

            Console.ReadLine();

        }
    }
}
