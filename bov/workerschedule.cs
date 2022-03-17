using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bov
{
    public partial class workerschedule : Form
    {

        public workerschedule()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void workerschedule_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("3");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            MySqlConnection myDbConn = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            string selectinfo = "Select bike_id from schedule where user_id=" + comboBox1.SelectedItem + " AND week LIKE '" + dateTimePicker1.Text +"';";
            myDbConn.Open();
            MySqlCommand cmd = new MySqlCommand(selectinfo, myDbConn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            
            myDbConn.Close();










        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[0].Value);

                if (s == true)
                {
                    string updatestatus = "UPDATE bikes SET status='1' WHERE idbikes ='" + row.Cells[1].Value + "'";
                    

                    MySqlConnection myDbConn = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                    myDbConn.Open();
                    MySqlCommand cmd = new MySqlCommand(updatestatus, myDbConn);
                    cmd.ExecuteNonQuery();
                    myDbConn.Close();

                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
