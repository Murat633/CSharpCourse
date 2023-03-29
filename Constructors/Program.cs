using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            manager.List();

            Product product = new Product(1,"Laptop");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("product hello");
            personManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            this._count = count;    
        }

        public CustomerManager() { }

        public void List()
        {
            Console.WriteLine("Listed {0} ştems",_count);

        }

        public void Add() { 
            Console.WriteLine("added");
        }
    }

    class Product
    {
        private int _id;
        private String _name;
        public Product(int id,String name)
        {
            this._name = name;
            this._id = id;
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger { 
        public void Log()
        {
            Console.WriteLine("logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("loged to file");
        }
    }

    class EmployeeManager
    {
        ILogger logger;
        public EmployeeManager(ILogger logger)
        {
            this.logger = logger;
        }

        public void Add()
        {
            logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        string _message;
        public BaseClass(String entity)
        {
            _message = entity; 
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_message);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(String entity) : base(entity)
        {
        }

        public void Add()
        {
            Console.WriteLine("added");
            Message();
        }
    }

    static class Teacher
    {
        public static void add()
        {
            Console.WriteLine("sa");
        }
    }
}
