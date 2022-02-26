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
        private int rowIndex = 0;
        public Cart(Order order, Catalog catalog)
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

            order.totalPrice = 0;
            order.estimateDate = DateTime.Today;
            order.totalBuildingTime = 0;
            order.TotalOrder();
            deliveryDate.Text = order.estimateDate.ToString();
            totalCost.Text = order.totalPrice.ToString() + "€";

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

            if (dataGridView1.Rows.Count > 1)
            {
                order.totalPrice = 0;
                order.estimateDate = DateTime.Today;
                order.totalBuildingTime = 0;
                order.TotalOrder();
                deliveryDate.Text = order.estimateDate.ToString();
                totalCost.Text = order.totalPrice.ToString() + "€";
            }
            else
            {
                order.totalPrice = 0;
                totalCost.Text = order.totalPrice.ToString() + "€";
                order.estimateDate = null;
                deliveryDate.Text = "/";
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


        private void submitPurchase_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("Your cart is currently empty");
            }
            else
            {
                if (Lastname.Text != "" && textBox_firstname.Text != "" && textBox_adress.Text != "" && textBox_TVA.Text != "")
                {
                    Customer customer = new Customer(
                        Lastname.Text,
                        textBox_firstname.Text,
                        textBox_adress.Text,
                        textBox_TVA.Text
                        );
                    order.CustomerLinked(customer);
                    this.Hide();
                    PurchaseConfirmation frm3 = new PurchaseConfirmation(catalog);
                    frm3.Show();
                }
                else
                {
                    MessageBox.Show("You forgot to put a customer");
                }
            }
        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {
            //string a = Lastname.Text;
        }

        

        private void label_firstname_Click(object sender, EventArgs e)
        {

        }

        private void label_adress_Click(object sender, EventArgs e)
        {

        }

        private void label_TVA_Click(object sender, EventArgs e)
        {

        }

        private void label_lastname_Click(object sender, EventArgs e)
        {

        }

        private void textBox_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TVA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
