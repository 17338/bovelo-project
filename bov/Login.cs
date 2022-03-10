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

namespace Bovelo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.Text = "Admin";
            textBox2.PasswordChar = '*';


        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            MySqlConnection connect = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
            string query = "Select * from user Where UserName = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connect);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                MainMenu menu = new MainMenu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
