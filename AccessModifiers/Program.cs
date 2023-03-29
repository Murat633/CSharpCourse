using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int id;
        public void save()
        {            
            Console.WriteLine("saved");
        }
    }

    class Student:Customer
    {

        public void Save()
        {
            Customer customer = new Customer();
            //customer.id;
        }
    }

    public class Course
    {
        public String MyProperty { get; set; }
    }


    //NOT: Private prop Sadece Kendi Sınıfında Çağırıla bilir.
    //NOT: Protected yine private ile aynı ama tek farkı extends edildiğinde sınıf ile birliktede kullanılır.
    //NOT: public prop new olduğu her yerden çağırıla bilir.
    //NOT: internal class proje içerisinde istediğimiz her yerden erişim sağlamamıza olanak sağlar
    //ve bir class'ın default öcelliği internal'dır.
    //Not: Public class farklı bir proje'ye referans olarak eklendiğinde kullanıla bilir.
}
