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
        Catalog catalog;
        Order order;
        private int rowIndex=0;
        public Cart(Order order,Catalog catalog)
        {          
            InitializeComponent();
            
            this.catalog = catalog;
            this.order = order;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Bike model";
            dataGridView1.Columns[1].Name = "Size";
            dataGridView1.Columns[2].Name = "Color";
            //DataGridViewComboBoxColumn AliasDataTypeCombo = new DataGridViewComboBoxColumn();
            //dataGridView1.Columns.Add(AliasDataTypeCombo);
            dataGridView1.Columns[3].Name = "Quantity";
            foreach (OrderLine orderline in order.orderLines)
            {
                string[] row = new string[] { orderline.bikeModel.name.ToString(), orderline.size.ToString(), orderline.color.ToString(), orderline.quantity.ToString() };
                dataGridView1.Rows.Add(row);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            catalog.Show(); 
        }
       
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(this.rowIndex);
            order.DeleteOrderLine(this.rowIndex);
            dataGridView1.Rows.Clear();
            foreach (OrderLine orderline in order.orderLines)
            {
                string[] row = new string[] { orderline.bikeModel.name.ToString(), orderline.size.ToString(), orderline.color.ToString(), orderline.quantity.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[1];
                this.contextMenuStrip1.Show(dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
