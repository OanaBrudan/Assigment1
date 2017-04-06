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
    public partial class OrdersF : Form
    {
        public OrdersF()
        {
            InitializeComponent();
        }

        private void btn_AddOrder(object sender, EventArgs e)
        {
            Order orders = new Order();
            orders.ID = Convert.ToInt32(txtid.Text);
            orders.Customer = txtcustomer.Text;
            orders.Address = txtaddress.Text;
            orders.Date = txtdate.Value;
            orders.Status = txtstatus.Text;

            DataAccess d1 = new DataAccess();
            d1.AddOrder(orders);
            MessageBox.Show("Operation succesful");
        }

        private void btn_EditOrder(object sender, EventArgs e)
        {
            Order orders = new Order();
            orders.ID = Convert.ToInt32(txtid.Text);
            orders.Customer = txtcustomer.Text;
            orders.Address = txtaddress.Text;
            orders.Date = txtdate.Value;
            orders.Status = txtstatus.Text;

            DataAccess d1 = new DataAccess();
            d1.UpdateOrder(orders);
            MessageBox.Show("Operation succesful");
        }

        private void btn_RetrieveOrder(object sender, EventArgs e)
        {
            try
            {
                DataAccess d1 = new DataAccess();

                gridOrders.DataSource = d1.RetrieveOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmptyControls()
        {
            txtid.Text = string.Empty;
            txtcustomer.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtdate.Value = DateTime.Now;
            
            txtstatus.Text = string.Empty;
            gridOrders.SelectedRows[0].Selected = false;
        }

       

        private void gridOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (gridOrders.SelectedRows.Count > 0)
            {
                Order orders = gridOrders.SelectedRows[0].DataBoundItem as Order;
                if (orders != null)
                {


                    txtcustomer.Text = orders.Customer;
                    txtid.Text = orders.ID.ToString();
                    txtaddress.Text = orders.Address;
                    txtdate.Value = orders.Date;
                    txtstatus.Text = orders.Status;
                }
            }
        }

        private void gridO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Order(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
