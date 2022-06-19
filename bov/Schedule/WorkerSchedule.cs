using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bov.classes;
using MySql.Data.MySqlClient;

namespace bov.Schedule
{
    public partial class WorkerSchedule : Form
    {
        public WorkerSchedule()
        {
            InitializeComponent();
            MySqlConnection myDbConn = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            string WORKERSRECUP = "SELECT Name FROM bovelo.user WHERE job = 'Assembly worker';";
            myDbConn.Open();
            MySqlCommand cmd = new MySqlCommand(WORKERSRECUP, myDbConn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader oReader = cmd.ExecuteReader();

            try
            {
                while (oReader.Read())
                {
                    comboBox1.Items.Add(oReader.GetValue(0).ToString());
                }
            }
            finally
            {
                oReader.Close();
            }
        }










        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }







        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {







        }

        private void OK_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            List<List<string>> bikes = database.getfromdbbyquery("Select bike_id from schedule inner join bovelo.user as u on user_id = u.id  where u.UserName= '" + comboBox1.SelectedItem + "' AND week LIKE '" + dateTimePicker1.Text + "';");


            //MySqlConnection myDbConn = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            //string selectinfo = "Select bike_id from schedule inner join bovelo.user as u on user_id = u.id  where u.UserName= '" + comboBox1.SelectedItem + "' AND week LIKE '" + dateTimePicker1.Text + "';";

            //myDbConn.Open();
            //MySqlCommand cmd = new MySqlCommand(selectinfo, myDbConn);
            //cmd.CommandType = CommandType.Text;
            //MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "bikeid";
            dataGridView1.Columns[1].Name = "model";
            foreach (List<string> elem in bikes)
            {
                List<List<string>> model = database.getfromdbbyquery("Select modelbike_idmodelbike from bikes  where idbikes = '" + elem[0] + "';");
                foreach (List<string> el in model)
                {
                    string[] row = new string[] { elem[0], el[0] };
                    dataGridView1.Rows.Add(row);

                }

            }

            DataGridViewCheckBoxColumn dgvCmba = new DataGridViewCheckBoxColumn();
            dgvCmba.Name = "Done";
            dataGridView1.Columns.Add(dgvCmba);










            //myDbConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[2].Value);

                if (s == true)
                {
                    string updatestatus = "UPDATE bikes SET status='1' WHERE idbikes ='" + row.Cells[0].Value + "'";


                    MySqlConnection myDbConn = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                    myDbConn.Open();
                    MySqlCommand cmd = new MySqlCommand(updatestatus, myDbConn);
                    cmd.ExecuteNonQuery();
                    myDbConn.Close();

                }
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
