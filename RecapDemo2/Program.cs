using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new FileLogger());
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        ILogger logger;
        public CustomerManager(ILogger logger) {
            this.logger = logger;
        }
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Customer Added");

        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to File");
        }
    }
}
