using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.add();
            database.remove();

            Database database1 = new SqlServer();
            database1.add();
            database1.remove();

            Console.ReadLine();
        }
    }


    abstract class Database
    {
        public void add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void remove();
    }

    class SqlServer : Database
    {
        public override void remove(){ Console.WriteLine("deleted by MySql"); ; }
    }


    class Oracle : Database
    {
        public override void remove() { Console.WriteLine("deleted by oracle"); }
    }
}
