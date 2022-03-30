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
using bov.Schedule;
using bov.Stock;

namespace Bovelo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Catalog_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            this.Hide();
            catalog.Show();
        }

        private void UserSettings_Click(object sender, EventArgs e)
        {
            UserSetting userSetting = new UserSetting();
            this.Hide();
            userSetting.Show();
        }

        private void Planning_Click(object sender, EventArgs e)
        {
            DoSchedule doScheddule = new DoSchedule();
            this.Close();
            doScheddule.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            this.Hide();
            stock.Show();
        }
    }
}
