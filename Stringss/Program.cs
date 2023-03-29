using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sentence = "My fullname is Murat Akyol";

            var result = sentence.Length;
            var result2 = sentence.Clone();// klon - ref alır.

            bool result3 = sentence.EndsWith("l"); // true | false
            bool result4 = sentence.StartsWith("l"); // true | false

            var result5 = sentence.IndexOf("Murat"); // -1 | index
            var result6 = sentence.LastIndexOf("Murat"); // -1 | index

            var result7 = sentence.Insert(0,"Murat "); // ekleme yapar
            var result8 = sentence.Substring(3,4); // yazıyı kırp

            var result9 = sentence.ToLower(); // yazıyı küçük harfe çevirir.
            var result10 = sentence.ToUpper(); // yazıyı büyük harfe çevirir.

            var result11 = sentence.Replace(" ","/");
            var result12 = sentence.Remove(11);


            Console.WriteLine(result12);
            Console.ReadLine();
        }
    }
}
