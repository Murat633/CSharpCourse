using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true;");
        public List<Product> GetAll()
        {


            // bağlantı kapalı ise Bağlantıyı aç            
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product= new Product()
                {
                    Id = Convert.ToInt32(reader["id"]), 
                    Name = Convert.ToString(reader["Name"]),
                    UnitPrice  = Convert.ToDecimal(reader["Price"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }            


            reader.Close();
            _connection.Close();

            return products;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("INSERT INTO Products values(@name,@unitPrice,@StockAmount)", _connection);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            cmd.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Update Products set Name=@Name,Price=@UnitPrice,StockAmount=@stockAmount WHERE id=@id", _connection);
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            cmd.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Delete From Products Where id=@id",_connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            _connection.Close();
        }

        public DataTable GetAll2()
        {            
            // bağlantı kapalı ise Bağlantıyı aç
            if (_connection.State == ConnectionState.Closed){ _connection.Open(); }

            SqlCommand command = new SqlCommand("SELECT * FROM Products",_connection);
            
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            
            reader.Close();
            _connection.Close();

            return dataTable;
        }

        private void ConnectionControl(){ if (_connection.State == ConnectionState.Closed) { _connection.Open(); }}
    }
}
