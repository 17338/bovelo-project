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

namespace Bovelo
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            MySqlConnection myDbConn = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
            myDbConn.Open();
            string selectinfo = "Select * from user ;";
            MySqlCommand cmd = new MySqlCommand(selectinfo, myDbConn);


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
            MySqlConnection myDbConn = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
            myDbConn.Open();
            string selectinfo = "Select * from user ;";
            MySqlCommand cmd = new MySqlCommand(selectinfo, myDbConn);


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
                MySqlConnection myDbConn = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");

                myDbConn.Open();
                MySqlCommand cmd = new MySqlCommand(del, myDbConn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                myDbConn.Close();
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
                MySqlConnection myDbConn = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
                myDbConn.Open();
                string edit = "SELECT Name, LastName, UserName, Password, Job  FROM user WHERE  id=" + row.Cells[1].Value.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(edit, myDbConn);
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

                myDbConn.Close();


            }


        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }

        private void EditUser_Load_1(object sender, EventArgs e)
        {

        }
    }
}
