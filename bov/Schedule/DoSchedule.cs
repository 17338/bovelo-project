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

namespace bov.Schedule
{
    public partial class DoSchedule : Form
    {
        public DoSchedule()
        {
            InitializeComponent();
        }

        Database database = new Database();
        private void DoSchedule_Load(object sender, EventArgs e)
        {
            List<List<string>> workers = database.getfromdbbyquery("SELECT * FROM bovelo.user WHERE job = 'Assembly worker';");
            foreach (List<string> worker in workers)
            {
                checkedListBox1.Items.Add(worker[3]);
            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            var confirmResult1 = MessageBox.Show("Are you sure to do this schedule with these workers ??",
                                     "Confirm because you can't undo !!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult1 == DialogResult.Yes && checkedListBox1.CheckedItems.Count != 0)
            {
                listBox1.Items.Clear();
                foreach (string elem in checkedListBox1.CheckedItems)
                {

                    listBox1.Items.Add(elem);
                }
                button1.Visible = false;

                int nbWorkers = listBox1.Items.Count;
                int hours = 8;

                int total = hours * nbWorkers;
                List<List<string>> bikes = database.getfromdbbyquery("SELECT b.idbikes, b.status, m.buildingtime, o.idorderLine, o.order_idorder, ord.deliveryEstimateDate " +
                    "FROM bovelo.bikes as b " +
                    "INNER JOIN  bovelo.modelbike as m ON b.modelbike_idmodelbike = m.idmodelbike " +
                    "INNER JOIN bovelo.orderline as o ON b.orderline_idorderline = o.idorderLine " +
                    "INNER JOIN bovelo.order as ord ON o.order_idorder = ord.idorder " +
                    "WHERE b.status = 0  AND b.idbikes not in (select bike_id from bovelo.schedule) " +
                    "ORDER BY b.idbikes " +
                    "LIMIT " + total + ";");

                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Bikeid";
                dataGridView1.Columns[1].Name = "Order id ";
                dataGridView1.Columns[2].Name = "OrderLine id";
                dataGridView1.Columns[3].Name = "BuildingTime";
                dataGridView1.Columns[4].Name = "Delivery estimated date";

                foreach (List<string> elem in bikes)
                {
                    string[] row = new string[] { elem[0], elem[4], elem[3], elem[2], elem[5] };
                    dataGridView1.Rows.Add(row);
                }
                DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
                foreach (string elem in listBox1.Items)
                {
                    dgvCmb.Items.Add(elem);
                }
                dgvCmb.Name = "Worker";

                dataGridView1.Columns.Add(dgvCmb);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    row.Cells[5].Value = listBox1.Items[row.Index % listBox1.Items.Count];

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to do this schedule for this week" + dateTimePicker1.Value.ToString("yyyy-M-dd") + " ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    Console.WriteLine(database.getfromdbbyquery("SELECT id FROM bovelo.user WHERE UserName = '" + row.Cells[5].Value + "';")[0][0]);
                    string adddb = "INSERT INTO bovelo.schedule (bike_id, user_id, week) " +
                   "VALUES ( " +
                     row.Cells[0].Value + ", '" +
                     database.getfromdbbyquery("SELECT id FROM bovelo.user WHERE UserName = '" + row.Cells[5].Value + "';")[0][0] + "', '" +
                     dateTimePicker1.Value.ToString("yyyy-M-dd") + "'); ";
                    database.sendToDB(adddb);
                }
                this.Close();


                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
