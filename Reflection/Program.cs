using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var tip = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());
            var instance = Activator.CreateInstance(tip, 6, 5);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            var metotlar = tip.GetMethods();
            foreach (var metot in metotlar)
            {
                Console.WriteLine(metot.Name);
                Console.WriteLine("-----------------------------");
                foreach (var parametre in metot.GetParameters())
                {
                    Console.WriteLine(parametre.Name);
                }
                Console.WriteLine("-------------new-------------");

            }

            Console.ReadLine();
        }

        class DortIslem
        {

            private int _sayi1;
            private int _sayi2;

            public DortIslem(int sayi1,int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public int Topla(int s1, int s2)
            {
                return s1 + s2;
            }

            public int Carp(int s1, int s2)
            {
                return s1 * s2;
            }

            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }

            public int Carp2()
            {
                return _sayi1 * _sayi2;
            }

        }
    }
}
