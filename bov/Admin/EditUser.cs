using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Bovelo
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            //MySqlConnection DataBaseConnect = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
            MySqlConnection DataBaseConnect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            DataBaseConnect.Open();
            string selectinfo = "Select * from user ;";
            MySqlCommand cmd = new MySqlCommand(selectinfo, DataBaseConnect);


            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            Column1.ValueType = typeof(bool);
            Column1.Name = "Chk";
            Column1.HeaderText = "CheckBox";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserSetting userSetting = new UserSetting();
            this.Hide();
            userSetting.Show();
        }

        private void USERS_Click(object sender, EventArgs e)
        {
            //MySqlConnection DataBaseConnect = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
            MySqlConnection DataBaseConnect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
            DataBaseConnect.Open();
            string selectinfo = "Select * from user ;";
            MySqlCommand cmd = new MySqlCommand(selectinfo, DataBaseConnect);


            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            Column1.ValueType = typeof(bool);
            Column1.Name = "Chk";
            Column1.HeaderText = "CheckBox";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Row has been Deleted");
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[0].Value);

                if (s == true)
                {
                    toDelete.Add(row);
                }
            }

            foreach (DataGridViewRow row in toDelete)
            {
                string del = "DELETE FROM user WHERE id=" + row.Cells[1].Value.ToString() + ";";
                MySqlConnection DataBaseConnect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                //MySqlConnection DataBaseConnect = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");

                DataBaseConnect.Open();
                MySqlCommand cmd = new MySqlCommand(del, DataBaseConnect);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                DataBaseConnect.Close();
                dataGridView1.Rows.Remove(row);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> toEdit = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[0].Value);

                if (s == true)
                {
                    toEdit.Add(row);
                }
            }

            foreach (DataGridViewRow row in toEdit)
            {
                //MySqlConnection DataBaseConnect = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
                MySqlConnection DataBaseConnect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                DataBaseConnect.Open();
                string edit = "SELECT Name, LastName, UserName, Password, Job  FROM user WHERE  id=" + row.Cells[1].Value.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(edit, DataBaseConnect);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                AddUser addUser = new AddUser();

                addUser.textBox5.Text = sdr["Name"].ToString();
                addUser.textBox6.Text = sdr["LastName"].ToString();
                addUser.textBox7.Text = sdr["UserName"].ToString();
                addUser.textBox8.Text = sdr["Password"].ToString();
                addUser.comboBox1.Text = sdr["Job"].ToString();
                dataGridView1.Rows.Remove(row);

                this.Hide();
                addUser.Show();

                DataBaseConnect.Close();


            }


        }


    }
}
