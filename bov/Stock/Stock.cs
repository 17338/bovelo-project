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

namespace bov.Stock
{
    public partial class Stock : Form
    {
        string connStr = "server=pat.infolab.ecam.be;port=63334;userid=Bovelo;pwd=Bovelo;persistsecurityinfo=True;database=bovelo";
        int idpart = 0;
        public Stock()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connStr))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("StockAddOrUpdate", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idpart", idpart);
                mySqlCmd.Parameters.AddWithValue("_name", NameInput.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_quantity", QuantityInput.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_location", LocationInput.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_color", ColorInput.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_size", SizeInput.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                Clear();
                GridFill();
                MessageBox.Show("Submitted Successfully");
                //Clear();
                

            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connStr))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PartViewStock", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                StockView.DataSource = dt;
                //StockView.Columns[0].Visible = false;
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            IDInput.Text=NameInput.Text = QuantityInput.Text = LocationInput.Text = ColorInput.Text = SizeInput.Text = "";
            idpart = 0;
            SaveBtn.Text = "Save";
            DeleteBtn.Enabled = false;
        }

        private void StockView_DoubleClick(object sender, EventArgs e)
        {
            if (StockView.CurrentRow.Index != -1)
            {
                idpart = Convert.ToInt32(StockView.CurrentRow.Cells[0].Value.ToString());
                NameInput.Text = StockView.CurrentRow.Cells[1].Value.ToString();
                ColorInput.Text = StockView.CurrentRow.Cells[2].Value.ToString();
                SizeInput.Text = StockView.CurrentRow.Cells[3].Value.ToString();
                QuantityInput.Text = StockView.CurrentRow.Cells[4].Value.ToString();
                LocationInput.Text = StockView.CurrentRow.Cells[5].Value.ToString();
                SaveBtn.Text = "Update";
                DeleteBtn.Enabled = Enabled;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connStr))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PartSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", SearchInput.Text);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                StockView.DataSource = dt;
                //StockView.Columns[0].Visible = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connStr))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("PartDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idpart", idpart);
                mySqlCmd.ExecuteNonQuery();
                Clear();
                GridFill();
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Bovelo.MainMenu mainmenu = new Bovelo.MainMenu();
            mainmenu.Show();
        }
    }
}
