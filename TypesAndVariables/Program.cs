using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(tamSayi);
            double number5 = 10.4;
            decimal number6 = 100.50m;
            char character = 'A';
            String City = "Ankara";
            bool condition = false;
            byte number4 = 255; // max - 8 bit
            short number3 = -32768; // max - 16 bit
            int number1 = 2147483647; // max - 32 bit
            long number2 = 9223372036854775807; // Max - 64 Bit
            var number7 = 'A';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number5 is {0}",number5);
            Console.WriteLine("Number6 is {0}",number6);
            Console.WriteLine("Number7 is {0}",number7);
            Console.WriteLine("Character is {0}",(int)character);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
