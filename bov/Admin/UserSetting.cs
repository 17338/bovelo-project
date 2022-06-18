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
    public partial class UserSetting : Form
    {       

        public UserSetting()
        {
            InitializeComponent();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            this.Hide();
            editUser.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            this.Hide();
            adduser.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        
    }
}
