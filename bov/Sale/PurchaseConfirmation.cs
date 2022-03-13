using bov.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bov
{
    public partial class PurchaseConfirmation : Form
    {
        Catalog catalog;
        public PurchaseConfirmation(Catalog catalog)
        {
            InitializeComponent();
            
            this.catalog = catalog;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Catalog new_catalog = new Catalog();
            new_catalog.Show();
        }
    }
}
