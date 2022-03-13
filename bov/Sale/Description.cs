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
    public partial class Description : Form
    {
        Catalog catalog;
        BikeModel bikeModel;
        string path = @"C:\\Users\\zakbu\\OneDrive\\Documents\\GitHub\\bovelo-project\\bov\\";
        //string path = @"C:\\Users\\Tafita\\Downloads\\bovelo-project-main\\bov\\";
        public Description(BikeModel bikeModel, Catalog catalog)
        {
            InitializeComponent();
            this.catalog = catalog;
            this.bikeModel = bikeModel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            catalog.Show();

        }

        private void Description_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path + bikeModel.image);
            label1.Text = bikeModel.description;
            name1.Text = bikeModel.name;
        }
    }
}
