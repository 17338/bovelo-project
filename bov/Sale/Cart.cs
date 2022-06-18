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
        TheCatalog catalog;
        Order order;
        private int rowIndex = 0;
        public Cart(Order order, TheCatalog catalog)
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
            EstimativeDeliveryDateDisplay.Text = order.estimateDate.ToString();
            TotalCostDisplay.Text = order.totalPrice.ToString() + "€";

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
                EstimativeDeliveryDateDisplay.Text = order.estimateDate.ToString();
                TotalCostDisplay.Text = order.totalPrice.ToString() + "€";
            }
            else
            {
                order.totalPrice = 0;
                TotalCostDisplay.Text = order.totalPrice.ToString() + "€";
                order.estimateDate = null;
                EstimativeDeliveryDateDisplay.Text = "/";
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToTheCatalogBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            catalog.Show();
        }

        private void SubmitPurchaseBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1)
            {
                EmptyCartMsg emptyCart = new EmptyCartMsg();
                emptyCart.Show();
            }
            else
            {
                if (LastnameInput.Text != "" && FirstnameInput.Text != "" && AdressInput.Text != "" && TVAInput.Text != "")
                {
                    Customer customer = new Customer(
                        LastnameInput.Text,
                        FirstnameInput.Text,
                        AdressInput.Text,
                        TVAInput.Text
                        );
                    order.CustomerLinked(customer);
                    Database database = new Database();
                    database.AddCustomerInDb(customer);
                    database.AddOrderInDb(order);
                    foreach (OrderLine orderLine in order.orderLines)
                    {
                        database.AddOrderLineInDb(orderLine);
                        for (int i = 0; i < orderLine.quantity; i++)
                        {
                            Bike bike = new Bike(orderLine.bikeModel);
                            database.AddBikeInDb(bike);
                        }
                    }
                    this.Hide();
                    PurchaseConfirmation frm3 = new PurchaseConfirmation(catalog);
                    frm3.Show();
                }
                else
                {
                    MissingCustomerMsg missingCustomer = new MissingCustomerMsg();
                    missingCustomer.Show();
                }
            }
        }
    }
}
