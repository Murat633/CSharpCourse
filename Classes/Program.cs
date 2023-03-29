using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.update();

            ProductManager productManager = new ProductManager();
            productManager.add();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Murat";
            customer.LastName = "Akyol";
            customer.City = "Ankara";
           
            Customer customer2 = new Customer
            {
                City="Adana",FirstName="Ahmet",LastName="Akyol",Id=2
            };

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    }


    
}
