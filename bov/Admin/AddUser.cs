using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
                //MySqlConnection DatabaseConnexion = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
                MySqlConnection DatabaseConnexion = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                DatabaseConnexion.Open();

                string addinfo = "INSERT INTO user (Name, LastName, UserName, Password, Job) VALUES(@Name, @LastName, @UserName, @Password, @Job);";
                MySqlCommand UserData = new MySqlCommand(addinfo, DatabaseConnexion);

                UserData.Parameters.AddWithValue("@Name", NAME);
                UserData.Parameters.AddWithValue("@LastName", LASTNAME);
                UserData.Parameters.AddWithValue("@UserName", USERNAME);
                UserData.Parameters.AddWithValue("@Password", PASSWORD);
                UserData.Parameters.AddWithValue("@Job", JOB);


                UserData.ExecuteReader();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source " + ex).ToString();
            }
            finally
            {
                //MySqlConnection DataBaseConnexion = new MySqlConnection(@"server=127.0.0.1;userid=root;pwd=root;persistsecurityinfo=True;database=bovelo;port=3306");
                MySqlConnection DataBaseConnexion = new MySqlConnection(@"server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo");
                DataBaseConnexion.Close();

            }

            UserSetting userSetting = new UserSetting();
            this.Hide();
            MessageBox.Show("User saved succesffuly");
            userSetting.Show();

        }

    }
}
