using bov.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bov
{

    public partial class Catalog : Form
    {
        OrderLine orderLine;
        CatalogShop catalogShop = new CatalogShop();
        BikeModel bike1;
        BikeModel bike2;
        BikeModel bike3;
        Order order = new Order();
        string path = @"C:\\Users\\zakbu\\OneDrive\\Documents\\GitHub\\bovelo-project\\bov\\";
        //string path = @"C:\\Users\\Tafita\\Downloads\\bovelo-project-main\\bov\\";


        public Catalog()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            catalogShop.GetAllBikeModel();

            bike1 = catalogShop.bikesModel[0];
            bike2 = catalogShop.bikesModel[1];
            bike3 = catalogShop.bikesModel[2];

            name1.Text = bike1.name;
            name2.Text = bike2.name;
            name3.Text = bike3.name;

            price1.Text = bike1.price.ToString();
            price2.Text = bike2.price.ToString();
            price3.Text = bike3.price.ToString();
           
            pictureBox1.Image = Image.FromFile(path + bike1.image);
            pictureBox2.Image = Image.FromFile(path + bike2.image);
            pictureBox3.Image = Image.FromFile(path + bike3.image);

            
            foreach (string color in catalogShop.Colors())
            {
                color_choice1.Items.Add(color);
                color_choice2.Items.Add(color);
                color_choice3.Items.Add(color);
            }


            foreach (string size in catalogShop.Sizes())
            {
                size_choice1.Items.Add(size);
                size_choice2.Items.Add(size);
                size_choice3.Items.Add(size);

            }

            for (int i = 1; i < 51; i++)
            {
                quantity_choice1.Items.Add(i);
                quantity_choice2.Items.Add(i);
                quantity_choice3.Items.Add(i);
            }

        }
            private void add_cart1_Click(object sender, EventArgs e)
            {
                if (color_choice1.SelectedItem == null || size_choice1.SelectedItem == null || quantity_choice1.SelectedItem == null)
                {
                    MessageBox.Show("Selected a color or quantity or size please");
                }
                else
                {
                    int quantity = int.Parse(quantity_choice1.SelectedItem.ToString());
                    int size = int.Parse(size_choice1.SelectedItem.ToString());
                    string color = color_choice1.SelectedItem.ToString();
                    OrderLine orderLine = new OrderLine(bike1, quantity, size, color);
                    if (order.orderLines.Count == 0)
                    {
                        order.AddOrderLine(orderLine);
                    }
                    else
                    {
                        order.CheckOrderLineExist(orderLine);
                    }

                    MessageBox.Show("Order added in the cart");
                }
            }

            private void add_cart2_Click(object sender, EventArgs e)
            {
                if (color_choice2.SelectedItem == null || size_choice2.SelectedItem == null || quantity_choice2.SelectedItem == null)
                {
                    MessageBox.Show("Make sure to select a color, a quantity and a size please");
                }
                else
                {
                    int quantity = int.Parse(quantity_choice2.SelectedItem.ToString());
                    int size = int.Parse(size_choice2.SelectedItem.ToString());
                    string color = color_choice2.SelectedItem.ToString();
                    OrderLine orderLine = new OrderLine(bike2, quantity, size, color);
                    if (order.orderLines.Count == 0)
                    {
                        order.AddOrderLine(orderLine);
                    }
                    else
                    {
                        order.CheckOrderLineExist(orderLine);
                    }

                    MessageBox.Show("Order added in the cart");

                }
            }

            private void add_cart3_Click(object sender, EventArgs e)
            {
                if (color_choice3.SelectedItem == null || size_choice3.SelectedItem == null || quantity_choice3.SelectedItem == null)
                {
                    MessageBox.Show("Selected a color or quantity or size please");
                }
                else
                {

                    int quantity = int.Parse(quantity_choice3.SelectedItem.ToString());
                    int size = int.Parse(size_choice3.SelectedItem.ToString());
                    string color = color_choice3.SelectedItem.ToString();
                    orderLine = new OrderLine(bike3, quantity, size, color);
                    if (order.orderLines.Count == 0)
                    {
                        order.AddOrderLine(orderLine);
                    }
                    else
                    {
                        order.CheckOrderLineExist(orderLine);
                    }
                    MessageBox.Show("Order added in the cart");
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {

                if (order.orderLines.Count != 0)
                {

                    order.TotalOrder();
                    this.Hide();
                    Cart frm2 = new Cart(order, this);
                    frm2.Show();
                }

                else
                {
                    MessageBox.Show("Your cart is empty");
                }

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Description frm3 = new Description(bike1, this);
            frm3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Description frm3 = new Description(bike2, this);
            frm3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Description frm3 = new Description(bike3, this);
            frm3.Show();
        }

      
    }

    }

