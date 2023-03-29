using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void add();
        void update();
        void delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("sql added");
        }

        public void delete()
        {
            Console.WriteLine("sql deleted");
        }

        public void update()
        {
            Console.WriteLine("sql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("oracle added");
        }

        public void delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void update()
        {
            Console.WriteLine("oracle updated");
        }
    }

    class CustomerManager
    {
        
        public void add(ICustomerDal customerDal)
        {
            customerDal.add();
        }
    }
}
