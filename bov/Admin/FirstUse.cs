using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bovelo
{
    public partial class FirstUse : Form
    {
        public FirstUse()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }





        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            {
                string Password = textBox3.Text;
                string ConfirmPasword = textBox4.Text;
                if (Password != null && ConfirmPasword != null && Password == ConfirmPasword)
                {
                    string NAME = "Admin";
                    string LASTNAME = "Admin";
                    string USERNAME = "Admin";
                    string PASSWORD = textBox4.Text;
                    string JOB = "Administrator";
                    //server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306
                    //"server=localhost;user=root;database=group4;port=3306;password=root";
                    MySqlConnection DataBaseConnect = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                    try
                    {
                        DataBaseConnect.Open();
                        string addinfo = "INSERT INTO user (Name, LastName, UserName, Password, Job) VALUES(@Name, @LastName, @UserName, @Password, @Job);";
                        MySqlCommand cmd = new MySqlCommand(addinfo, DataBaseConnect);

                        cmd.Parameters.AddWithValue("@Name", NAME);
                        cmd.Parameters.AddWithValue("@LastName", LASTNAME);
                        cmd.Parameters.AddWithValue("@UserName", USERNAME);
                        cmd.Parameters.AddWithValue("@Password", PASSWORD);
                        cmd.Parameters.AddWithValue("@Job", JOB);
                        cmd.ExecuteReader();
                        Login login = new Login();
                        MessageBox.Show("Password saved, please log to continue");
                        this.Hide();
                        login.Show();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to connect to data source " + ex).ToString();
                    }
                    finally
                    {
                        DataBaseConnect.Close();

                    }
                }
                else
                {

                    MessageBox.Show("Password didn't match, please retype again");

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
