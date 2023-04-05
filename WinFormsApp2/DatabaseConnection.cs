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
        static HashInput hashInput = new HashInput();

        public void addUser(TextBox userName, TextBox password, string hash, byte[] salt) 
        {

            try
            {
                string connString = "server=localhost;uid=root;pwd=Password!;database=hashlogin";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.ConnectionString = connString;
                conn.Open();

                string sql = "insert into users(Username, HashedPassword, HashSalt)" +
                    "VALUES('"+userName.Text+ "','" + hash + "', '" + salt + "')";
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

        public DatabaseConnection compareUsernameAndPass(TextBox userName, TextBox password, string errorMessage = "Username or Password do not match.")
        {

            bool usernameMatches = false;
            try
            {
                string connString = "server=localhost;uid=root;pwd=Password;database=hashlogin";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.ConnectionString = connString;
                conn.Open();

                string sql = "SELECT * FROM users WHERE Username ='"+userName.Text+"' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    System.Diagnostics.Debug.WriteLine("getting here. "+reader.GetString("Username"));

                    if (userName.Text == reader.GetString("Username"))
                    {
                        usernameMatches = true;
                    }
                    else
                    {
                        throw new Exception("No matching username in the databse.");
                    }

                }

                conn.Close();

                if(usernameMatches)
                {
                    conn.Open();
                    System.Diagnostics.Debug.WriteLine("getting two.");
                    sql = "SELECT * FROM users WHERE Username ='" + userName.Text + "' LIMIT 1";
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();

                    string hashValue = string.Empty;
                    byte[] saltValue = Array.Empty<byte>();

                    while (reader.Read())
                    {
                        hashValue = reader.GetString("HashedPassword");
                        saltValue = (byte[])reader["HashSalt"];
                    }
                    System.Diagnostics.Debug.WriteLine("getting hash."+hashValue);
                    for(int i = 0; i < saltValue.Length; i++)
                    {
                        System.Diagnostics.Debug.WriteLine("getting salt." + saltValue[i]);
                    }

                    if (!hashInput.VerifyPassword(password, hashValue, saltValue))
                    {
                        throw new Exception(errorMessage);
                    }
                }

                conn.Close();   
                return this;

            }


            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return this;
            }
        }

    }
}
