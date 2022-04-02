using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bov;


namespace Bovelo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            UserSetting userSetting = new UserSetting();
            this.Hide();
            userSetting.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            this.Hide();
            catalog.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            workerschedule workerschedule = new workerschedule();
            this.Hide();
            workerschedule.Show();
        }
    }
}
