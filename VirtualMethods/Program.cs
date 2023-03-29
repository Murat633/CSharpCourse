using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            Database database2 = new Mysql();
            database2.Add();

            Console.ReadLine();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by Default");
            }

            public virtual void Delete() 
            {
                Console.WriteLine("Deleted by Default");
            }
        }

        class SqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("added by sql Code");
            }
        }

        class Mysql : Database
        {

        }
    }
}
