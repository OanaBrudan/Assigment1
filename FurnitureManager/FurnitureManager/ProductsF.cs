using FurnitureManager.BL;
using FurnitureManager.Models;
using FurnitureManager.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureManager
{
    public partial class ProductsF : Form
    {
        public ProductsF()
        {
            InitializeComponent();
        }

        private void lbl_IdProduct(object sender, EventArgs e)
        {

        }

        private void lbl_title(object sender, EventArgs e)
        {

        }

        private void lbl_description(object sender, EventArgs e)
        {

        }

        private void lbl_color(object sender, EventArgs e)
        {

        }

        private void lbl_size(object sender, EventArgs e)
        {

        }

        private void lbl_price(object sender, EventArgs e)
        {

        }

        private void lbl_stock(object sender, EventArgs e)
        {

        }

        private void txt_IDProduct(object sender, EventArgs e)
        {

        }

        private void txt_title(object sender, EventArgs e)
        {

        }

        private void txt_description(object sender, EventArgs e)
        {

        }

        private void txt_color(object sender, EventArgs e)
        {

        }

        private void txt_size(object sender, EventArgs e)
        {

        }

        private void txt_price(object sender, EventArgs e)
        {

        }

        private void txt_stock(object sender, EventArgs e)
        {

        }

        private void idProduct(object sender, EventArgs e)
        {

        }

        private void btn_createProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID = Convert.ToInt32(textid.Text);
            product.Title = texttitle.Text;
            product.Description = textdescription.Text;
            product.Color = textcolor.Text;
            product.Size = textsize.Text;
            product.Price = Convert.ToInt32(textprice.Text);
            product.Stock = Convert.ToInt32(textstock.Text);

            DataAccess d1 = new DataAccess();
            d1.AddProduct(product);
            MessageBox.Show("Operation succesful");
        }

        private void btn_updateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID = Convert.ToInt32(textid.Text);
            product.Title = texttitle.Text;
            product.Description = textdescription.Text;
            product.Color = textcolor.Text;
            product.Size = textsize.Text;
            product.Price = Convert.ToInt32(textprice.Text);
            product.Stock = Convert.ToInt32(textstock.Text);

            DataAccess d1 = new DataAccess();
            d1.UpdateProduct(product);
            MessageBox.Show("Operation succesful");
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ID = Convert.ToInt32(textid.Text);
            product.Title = texttitle.Text;
            product.Description = textdescription.Text;
            product.Color = textcolor.Text;
            product.Size = textsize.Text;
            product.Price = Convert.ToInt32(textprice.Text);
            product.Stock = Convert.ToInt32(textstock.Text);

            DataAccess d1 = new DataAccess();
            d1.DeleteProduct(product);
            MessageBox.Show("Operation succesful");
        }

        private void btn_ViewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess d1 = new DataAccess();

                gridProduct.DataSource = d1.RetrieveProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (gridProduct.SelectedRows.Count > 0)
            {
                Product product = gridProduct.SelectedRows[0].DataBoundItem as Product;
                if (product != null)
                {
                    textid.Text = product.ID.ToString();
                    texttitle.Text = product.Title;
                    textdescription.Text = product.Description;
                    textcolor.Text = product.Color;
                    textsize.Text = product.Size;
                    textprice.Text = product.Price.ToString();
                    textstock.Text = product.Stock.ToString();
                }
            }
        }

        private void EmptyControls()
        {
            textid.Text = string.Empty;
            texttitle.Text = string.Empty;
            textdescription.Text = string.Empty;
            textcolor.Text = string.Empty;
            textsize.Text = string.Empty;
            textprice.Text = string.Empty;
            textstock.Text = string.Empty;
            gridProduct.SelectedRows[0].Selected = false;
        }

       

        private void ProductsF_Load(object sender, EventArgs e)
        {

        }
    }
}
