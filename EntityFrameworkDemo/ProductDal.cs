using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            // using ile kullanılan nesne çalışmamız bittiğinde bellekten atılıyor.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            // using ile kullanılan nesne çalışmamız bittiğinde bellekten atılıyor.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Price >= price).ToList();
            }
        }

        public List<Product> GetByPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Price >= min && p.Price<=max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using(ETradeContext context = new ETradeContext())
            {                
                return context.Products.FirstOrDefault(p => p.Id == id);
            }
        }

        public void Add(Product product)
        {
            // using ile kullanılan nesne çalışmamız bittiğinde bellekten atılıyor.
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using(ETradeContext contex = new ETradeContext())
            {
                var entity = contex.Entry(product);
                entity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using(ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
