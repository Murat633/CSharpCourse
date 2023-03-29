using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cities = new string[] {
                "ankara","istanbul"
            };
            //cities[2] = "adıyaman";
            //ArrayList cities  = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Adana");
            //cities.Add("İstanbul");
            //cities.Add(1);


            //foreach (var City in cities)
            //{
            //    Console.WriteLine(City);
            //}

            List<string> list = new List<string>();
            list.Add("Adana");
            list.Add("İstanbul");

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer(1,"Murat"));
            //customers.Add(new Customer(2,"Mehmet"));
            //customers.Add(new Customer(3,"Ali"));
            //customers.Add(new Customer(4,"Ahmet"));

            List<Customer> customers = new List<Customer>
            {
                new Customer(1, "Murat"),
                new Customer(2, "Mehmet"),
                new Customer(3, "Ali"),
                new Customer(4, "Ahmet"),
                new Customer(5, "Akın"),
                new Customer(6, "Arda"),
            };

            var customer = new Customer(7,"Ahmet");

            customers.Add(customer);// ekleme işlemi
            customers.AddRange(new Customer[2]
            {
                new Customer(8,"Selim"),
                new Customer(9,"Salih"),
            });;

            //customers.Clear();
            ////Console.WriteLine(cities.Contains("ankara"));// içerisinde var mı ?
            //Console.WriteLine("Murat var mı :"+customers.Contains(customer));
            //Console.WriteLine(customers.IndexOf(customer));
            //Console.WriteLine(customers.LastIndexOf(customer));
            //customers.Insert(0,customer);
            //customers.RemoveAll(c=>c.FirstName=="Ahmet" || c.FirstName=="Salih");

            foreach (Customer item in customers)
            {
                Console.WriteLine(item.Id+" "+item.FirstName);
            }
            int count = customers.Count;
            Console.WriteLine("Count {0}",count);

            Dictionary<String,String> dic = new Dictionary<String,String>(); // key ve value değerine sahip bir object oluşturur.
            dic.Add("book", "kitap");
            dic.Add("computer", "bilgisayar");

            Console.WriteLine(dic["book"]);

            Console.ReadLine();
        }


        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

            public Customer(int id,String firstname)
            {
                Id = id;  
                FirstName = firstname;
            }
        }

    }
}
