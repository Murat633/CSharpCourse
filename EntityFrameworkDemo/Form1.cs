using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class form1 : Form
    {
        public ProductDal _productDal = new ProductDal();

        // Load Products
        public void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        public void SearchProducts(string key)
        {
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource= result;
        }

        // updateBox Visible Control
        public void IsUpdated(bool b)
        {
            updateBox.Visible = b;
        }

        public form1()
        {
            InitializeComponent();
        }


        private void form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = tbxProductName.Text,
                Price = Convert.ToDecimal(tbxProductPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            };

            _productDal.Add(product);
            LoadProducts();
            IsUpdated(false);
        }        

        private void dgwProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IsUpdated(true);

            tbxProductId.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString().Trim();
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString().Trim();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString().Trim();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString().Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),               
            };
            _productDal.Delete(product);
            LoadProducts();
            IsUpdated(false);
        }

        private void btnUpdateProduct(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(tbxProductId.Text),
                Name = tbxNameUpdate.Text,
                Price = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
            };
            _productDal.Update(product);
            LoadProducts();
            IsUpdated(false);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
    }
}
