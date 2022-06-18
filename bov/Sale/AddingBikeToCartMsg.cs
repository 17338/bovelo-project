using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bov.Sale
{
    public partial class AddingBikeToCartMsg : Form
    {
        public AddingBikeToCartMsg()
        {
            InitializeComponent();
        }

        private void BikesAddedBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
