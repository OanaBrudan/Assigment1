using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace FurnitureManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand("Select username, password from users where username=@username AND password=@password", conn);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);

            conn.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Login successfull");
            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }
    }
}
