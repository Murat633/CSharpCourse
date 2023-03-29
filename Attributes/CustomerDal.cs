using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class CustomerDal
    {
        //[Obsolete("Bu Method yerine artık AddNew Method'u kullanılabilir.")] // eski method haline getirir.
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id} {customer.FirstName} {customer.LastName} {customer.Age}");
        }

    }
}
