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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            textBox8.PasswordChar = '*';
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            UserSetting userSetting = new UserSetting();
            this.Hide();
            userSetting.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NAME = textBox5.Text;
            string LASTNAME = textBox6.Text;
            string USERNAME = textBox7.Text;
            string PASSWORD = textBox8.Text;
            string JOB = comboBox1.Text;
            try
            {
                MySqlConnection myDbConn = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
                myDbConn.Open();

                string addinfo = "INSERT INTO user (Name, LastName, UserName, Password, Job) VALUES(@Name, @LastName, @UserName, @Password, @Job);";
                MySqlCommand cmd = new MySqlCommand(addinfo, myDbConn);

                cmd.Parameters.AddWithValue("@Name", NAME);
                cmd.Parameters.AddWithValue("@LastName", LASTNAME);
                cmd.Parameters.AddWithValue("@UserName", USERNAME);
                cmd.Parameters.AddWithValue("@Password", PASSWORD);
                cmd.Parameters.AddWithValue("@Job", JOB);



                //string addinfo = "INSERT INTO user (Name, Last Name, UserName, Password, Job) VALUES(?, ?, ?, ?, ?);";

                //MySqlCommand cmd = new MySqlCommand(addinfo, myDbConn);
                //cmd.Parameters.Add(new MySqlParameter("Name", Convert.ToString(NAME)));
                //cmd.Parameters.Add(new MySqlParameter("Last Name", Convert.ToString(LASTNAME)));
                //cmd.Parameters.Add(new MySqlParameter("UserName", Convert.ToString(USERNAME)));
                //cmd.Parameters.Add(new MySqlParameter("Password", Convert.ToString(PASSWORD)));
                //cmd.Parameters.Add(new MySqlParameter("Job", Convert.ToString(JOB)));

                cmd.ExecuteReader();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source " + ex).ToString();
            }
            finally
            {
                MySqlConnection myDbConn = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
                myDbConn.Close();

            }

            UserSetting userSetting = new UserSetting();
            this.Hide();
            MessageBox.Show("User saved succesffuly");
            userSetting.Show();

        }

    }
}
