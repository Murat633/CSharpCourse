using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Topla(3,6));

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,9));
            Func<int> getRandomNumber = delegate (){return new Random().Next(1, 1000);};

            Func<int> getRandomNumber2 = () => new Random().Next(1, 1000);
            //Console.WriteLine(getRandomNumber2());
            //Thread.Sleep(1000); // 1 second sleep
            //Console.WriteLine(getRandomNumber2());

            ExceptionHandling(()=>Console.WriteLine(getRandomNumber2()));



            Console.ReadLine();
        }


        static int Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2 ;
        }

        static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "ahmet", "mehmet", "salih" };
                students[3] = "ali";
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("diziye daha fazla eleman ekleyemezsin");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ActionDemo()
        {
            ExceptionHandling(() =>
            {
                Find();
            });
        }

        static void ExceptionHandling(Action action)
        {
            try
            {
                action.Invoke();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Find()
        {
            List<String> students = new List<String> { "Ahmet", "Mehmet", "Salih" };

            if (!students.Contains("murat"))
            {
                throw new RecordNotfoundException($"murat not found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }
    }
}
