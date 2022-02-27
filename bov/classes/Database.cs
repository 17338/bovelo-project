using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bov.classes
{
    public class Database
    {
        
        public List<List<string>> getfromdb(string DBTable)
        { 
            var listFromDB = new List<List<string>>();
        
            string connStr = "server=localhost;user=root;database=group4;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM " + DBTable + ";";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var col = new List<string>();
                for (int j = 0; j < rdr.FieldCount; j++)
                {
                    col.Add(rdr[j].ToString());
                }
                listFromDB.Add(col);
            }
            rdr.Close();
            conn.Close();
            return listFromDB;
        }

        public List<List<string>> getfromdbbyquery(string query)
        {
            var listFromDB = new List<List<string>>();
            string connStr = "server=localhost;user=root;database=group4;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var col = new List<string>();
                for (int j = 0; j < rdr.FieldCount; j++)
                {
                    col.Add(rdr[j].ToString());
                }
                listFromDB.Add(col);
            }
            rdr.Close();
            conn.Close();
            return listFromDB;
        }
        public List<string> getBikeModelList()
        {
            List<string> bikeList = new List<string>();
            List<List<string>> bikemodel = getfromdb("modelbike");
            for (int i=0; i < bikemodel.Count(); i++ )
            {
                bikeList.Add(bikemodel[i][1]);
            }
            
            return bikeList;
        }

        public void sendToDB(string query) //is used to send anything to the database
        {
            string connStr = "server=localhost;user=root;database=group4;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);
            Console.WriteLine("Connecting to MySQL to send new element...");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("Element added to DB");
            cmd.Dispose();
            conn.Close();
        }

        public List<List<string>> getIdCustomer(Customer customer)
        {
            string queryOB = "SELECT * FROM customer WHERE firstName = '"
                + customer.firstName +
                "' AND lastName = '" + customer.lastName + "' AND address = '" +
                customer.adress + "' AND TVA = '" + customer.tva + "' ;";
            return getfromdbbyquery(queryOB);
        }

        public void AddCustomerInDb(Customer customer) //is used to pass a new order  HAVE TO CHANGE
        {
            if (getIdCustomer(customer).Count() ==0 )
            { 
            string queryOB = "INSERT INTO customer (lastname,firstname,address,TVA) VALUES('"
                + customer.lastName + "', '" +
               customer.firstName + "', '" +
                customer.adress + "', '" +
                customer.tva + "');" ;
            sendToDB(queryOB);
            }
        }

        

        public void AddOrderInDb(Order order) //is used to pass a new order  HAVE TO CHANGE
        {
           
            string queryOB = "INSERT INTO order (date,deliveryEstimateDate,totalPrice,status,customer_idcustomer) VALUES ('" 
                + order.date + "', '" + 
                order.estimateDate + "', '" + 
                order.totalPrice + "', '" +
                order.status + "', '" +
                3 + "'); ";
            
            sendToDB(queryOB);
        }

        

    }
}
