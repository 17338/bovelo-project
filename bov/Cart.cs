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
    public partial class Cart : Form
    {
        public Cart(Order order)
        {
            InitializeComponent();
            foreach (OrderLine orderLine in order.list_orderLines)
            {
                //pour afficher toutes les sous commandes.
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            
        }
    }
}
