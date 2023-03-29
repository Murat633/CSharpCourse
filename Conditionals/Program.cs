using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 201;
            if (number == 10)
            {
                Console.WriteLine("number is {0}", number);
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is {0}", number);
            }
            else
            {
                Console.WriteLine("Number isn't 10 or 20");
            }

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is {0}", number);
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is {0]", number);
            //        break;
            //    default:
            //        Console.WriteLine("Number isn't 10 or 20");
            //        break;
            //}

            if(number>=0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }else if(number>100 && number<=200)
            {
                Console.WriteLine("number is between 101-200");
            }else if (number>200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            Console.ReadLine();

        }
    }
}
