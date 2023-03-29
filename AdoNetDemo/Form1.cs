using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product()
                {
                    Name = tbxProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxProductPrice.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                };
                _productDal.Add(product);
                MessageBox.Show("Product Added!");
                LoadProducts();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen Alanları Doğru Bir Şeiklde Doldurduğunuzdan Emin Olun.");
            }
        }

        

        private void dgwProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBox.Visible = true;
            tbxProductId.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString().Trim();
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString().Trim();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString().Trim();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(tbxProductId.Text),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
            };
            _productDal.Update(product);
            LoadProducts();
            tbxNameUpdate.Text = "";
            tbxUnitPriceUpdate.Text = "";
            tbxStockAmountUpdate.Text = "";
            tbxProductId.Text = "";
            updateBox.Visible = false;
            MessageBox.Show("Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            updateBox.Visible=false;
            MessageBox.Show($"id:{id} Product Deleted");
        }
    }
}
