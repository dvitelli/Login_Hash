using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HashLogin
{
    internal class DatabaseConnection //help from Programming guru https://www.youtube.com/watch?v=d1aLhXXEofU&t=3s
    {
        
        /*public void connectToDatabase()
        {
            try
            {
                

              
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //failure to connect
         
        }*/

        public void addUser(TextBox userName, TextBox password, string hash, byte[] salt) 
        {
            try
            {
                string connString = "server=localhost;uid=root;pwd=FakePasswordLol;database=hashlogin";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.ConnectionString = connString;
                conn.Open();

                string sql = "select * from users";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Username: " + reader["Username"]);
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
            
        }

        public void login(MySqlConnection conn, TextBox userName, TextBox password, byte[] salt)
        {
            try
            {

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
