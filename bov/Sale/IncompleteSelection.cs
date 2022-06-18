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
    public partial class IncompleteSelection : Form
    {
        public IncompleteSelection()
        {
            InitializeComponent();
        }

        private void IncompleteSelectionBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
