using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] ogrenciler = {
                "Muhammet",
                "Murat",
                "Sema",
                "Kübra",
                "Esra",
                "Hikmet",
                "Enes",
                "Selman",
                "Hatce",
                "Kim kardaşyan"
            };

            String[,] ogrenciler2 = new String[7, 3 ]
            {
                {  "Ahmet" , "Mehmet" , "Salih"  },
                {  "Ahmet" , "Mehmet" , "Salih" },
                {  "Ahmet" , "Mehmet", "Salih"  },
                {  "Ahmet" , "Mehmet" , "Salih"  },
                {  "Ahmet" , "Mehmet", "Salih"  },
                {  "Ahmet" , "Mehmet" , "Salih"  },
                {  "Ahmet" , "Mehmet" , "Salih"  },
            };


            foreach (String grup in ogrenciler2 )
            {
               
                    Console.WriteLine(grup);
            }
            
            Console.ReadLine();
        }
    }
}
