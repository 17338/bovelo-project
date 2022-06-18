using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Bovelo;
using bov.classes;


namespace bov.Stock
{
    public partial class OrderParts : Form
    {
        string connStr = "server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo";
        public OrderParts()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //show parts to order
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connStr))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PartViewOrderParts", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        
        
        
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) //change the status
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connStr))
            {
                mysqlCon.Open();
                string query = "SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));select idorderparts,name,color,size,sum(quantity),status from orderparts where status=1 or status=2 group by name,color,size ORDER by status,idorderparts ;";
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, mysqlCon);
                MySqlCommandBuilder scb = new MySqlCommandBuilder(sqlDa);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                int a = (int)dataGridView1.SelectedRows[0].Index; //numéro de la ligne
                int b = (int) dataGridView1.SelectedRows[0].Cells[5].Value; //valeur de status
                if (b == 2){

                }
                dt.Rows[a][5] = b+1;
                sqlDa.Update(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void button3_Click(object sender, EventArgs e)//back to the main menu
        {
            //MainMenu mainMenu = new MainMenu();
            //this.Hide();
            //mainMenu.Show();
        }
    }
}
