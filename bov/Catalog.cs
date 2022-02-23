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
        CatalogShop catalogShop;
        BikeModel bike1;
        BikeModel bike2;
        BikeModel bike3;
        Order order = new Order();

        public Catalog()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<string[]> list_bike = new List<string[]>();
            string[] list = null;
            foreach (string line in File.ReadLines(@"C:\Users\zakbu\source\repos\bov\bov\bike_model.txt"))
                {
                  list = line.Split(';');
                  list_bike.Add(list);                 
                }
         
            catalogShop = new CatalogShop();
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

            pictureBox1.Image = Image.FromFile(@"C:\Users\zakbu\source\repos\bov\bov\explorer.jfif");
            pictureBox2.Image = Image.FromFile(@"C:\Users\zakbu\source\repos\bov\bov\explorer.jfif");
            pictureBox3.Image = Image.FromFile(@"C:\Users\zakbu\source\repos\bov\bov\explorer.jfif");

            foreach (string line in File.ReadLines(@"C:\Users\zakbu\source\repos\bov\bov\colors.txt"))
            {
                color_choice1.Items.Add(line);
                color_choice2.Items.Add(line);
                color_choice3.Items.Add(line);
            }

            foreach (string line in File.ReadLines(@"C:\Users\zakbu\source\repos\bov\bov\sizes.txt"))
            {

                size_choice1.Items.Add(line);
                size_choice2.Items.Add(line);
                size_choice3.Items.Add(line);

            }

            for(int i = 1; i < 101; i++)
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
                MessageBox.Show("Selected a color or quantity or size please");
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
                Cart frm2 = new Cart(order,this);
                frm2.Show();
            }

            else
            {
                MessageBox.Show("Your cart is empty");
            }
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void color1_Click(object sender, EventArgs e)
        {

        }

        private void price1_Click(object sender, EventArgs e)
        {

        }

        private void price2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
