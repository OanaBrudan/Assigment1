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
    public partial class UsersF : Form
    {
        public UsersF()
        {
            InitializeComponent();
        }

        private void l(object sender, EventArgs e)
        {

        }

        private void lbl_address(object sender, EventArgs e)
        {

        }

        private void lbl_name(object sender, EventArgs e)
        {

        }

        private void lbl_id(object sender, EventArgs e)
        {

        }

        private void txt_id(object sender, EventArgs e)
        {

        }

        private void txt_name(object sender, EventArgs e)
        {

        }

        private void txt_address(object sender, EventArgs e)
        {

        }

        private void btn_create(object sender, EventArgs e)
        {
         
          
        }
        

        private void btn_retrieve(object sender, EventArgs e)
        {

        }

        private void btn_update(object sender, EventArgs e)
        {

        }

        private void btn_delete(object sender, EventArgs e)
        {

        }

        private void UsersF_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_username(object sender, EventArgs e)
        {

        }

        private void txt_password(object sender, EventArgs e)
        {

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          
            User users = new User();
            users.ID = Convert.ToInt32(textid.Text);
            users.Name = textname.Text;
            users.Address = textaddress.Text;
            users.Username = textusername.Text;
            users.Password = textpassword.Text;
            users.IsAdmin = chkAdmin.Checked;

            DataAccess d1 = new DataAccess();
                d1.AddUser(users);
                MessageBox.Show("Operation succesful");
               
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            User users = new User();
            users.ID = Convert.ToInt32(textid.Text);
            users.Name = textname.Text;
            users.Address = textaddress.Text;
            users.Username = textusername.Text;
            users.Password = textpassword.Text;
            users.IsAdmin = chkAdmin.Checked;

            DataAccess d1 = new DataAccess();
            d1.UpdateUser(users);
            MessageBox.Show("Operation succesful");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            User users = new User();
            users.ID = Convert.ToInt32(textid.Text);
            users.Name = textname.Text;
            users.Address = textaddress.Text;
            users.Username = textusername.Text;
            users.Password = textpassword.Text;
            users.IsAdmin = chkAdmin.Checked;

            DataAccess d1 = new DataAccess();
            d1.DeleteUser(users);
            MessageBox.Show("Operation succesful");
        }

        private void btnretrieve_Click(object sender, EventArgs e)
        {
           try
            {
                DataAccess d1 = new DataAccess();

                gridusers.DataSource = d1.RetrieveUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void EmptyControls()
        {
            textid.Text = string.Empty;
            textname.Text = string.Empty;
            textaddress.Text = string.Empty;
            textusername.Text = string.Empty; 
            textpassword.Text = string.Empty;
            gridusers.SelectedRows[0].Selected = false;
        }
        
       
        private void gridusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridusers_SelectionChanged(object sender, EventArgs e)
        {
         if (gridusers.SelectedRows.Count > 0)
            {
                User users = gridusers.SelectedRows[0].DataBoundItem as User;
                if (users != null)
                {


                    textname.Text = users.Name;
                    textid.Text = users.ID.ToString();
                    textaddress.Text = users.Address;
                    textusername.Text = users.Username;
                    textpassword.Text = users.Password;
                }
            }
        }

        private void textadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
