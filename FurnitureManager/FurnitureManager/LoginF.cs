﻿using FurnitureManager.BL;
using FurnitureManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FurnitureManager
{
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
            textpassword.PasswordChar = '*';
        }

        private void lbl_username(object sender, EventArgs e)
        {

        }

        private void lbl_password(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void txt_username(object sender, EventArgs e)
        {

        }

        private void txt_password(object sender, EventArgs e)
        {

        }

        private void LoginF_Load(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if(textusername.Text=="admin"&&textpassword.Text=="admin"){
                Form f = new UsersF();
                    f.Show();
            }
            else{
                Form f = new ProductsF();
                    f.Show();
                    Form f1 = new OrdersF();
                    f1.Show();
            }
            /*UserOperations bl = new UserOperations();
            
           User user = new User(); 
            user = bl.Login(textusername.Text, textpassword.Text);
            
            if (user == null)
            {
                return;
            }
            else
            {
                if (user.IsAdmin.Equals(true))
                {
                    Form f = new UsersF();
                    f.Show();
                }
                if (user.IsAdmin.Equals(false))
                {
                    Form f = new ProductsF();
                    f.Show();
                    Form f1 = new OrdersF();
                    f1.Show();
                }
            }*/
        }
    }
}
