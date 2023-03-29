using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person{Name="Murat"},new Student{Name="Ahmet"},new Customer{Name="Mehmet"}
            };

            foreach(Person person in persons)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }

        class Customer : Person
        {
            public String City { get; set; }
        }

        class Student : Person
        {

        }
    }
}
