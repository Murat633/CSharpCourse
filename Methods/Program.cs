using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            int result = Add3(ref number1,number2);

            Console.WriteLine(result);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(20));
            Console.WriteLine(Add4(20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20));

            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int a,int b)
        {
           return a + b;
        }

        static int Add3(ref int a,int b)
        {
            a = 30;
            return a + b;
        }
        static int Multiply(int number1)
        {
            return number1 * number1;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
       
    }
}
