using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chinarhomes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new container());
        }
    }
    class userinfo
    {
        public static bool loggedin;
        public static string username;
        public static bool admin;
        public static string email;
        public static long lastid;
        public static string encmail;
    }


    class DBConnect
    {
        MySqlConnection conn;

        public DBConnect()
        {
            conn = new MySqlConnection("SERVER=148.72.232.182;DATABASE=chinarhomes;USER=chinarhomes;PASSWORD=Chinar@123chinar;");

        }



        public bool openConnection()
        {
            try
            {
                conn.Open();

                return true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Cannot connect to Server.\n\nPlease try again.", "Error!");
                return false;
            }
        }
        public bool closeConnection()
        {
            try
            {

                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
        public void nonQuery(String command)
        {
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                userinfo.lastid = cmd.LastInsertedId;
                this.closeConnection();
            }

        }


        public MySqlDataReader Query(String command)
        {
            MySqlDataReader datareader;
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                datareader = cmd.ExecuteReader();

                return (datareader);
            }

            return (null);
        }

        public int Count(String command)
        {
            int count = -1;
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                count = int.Parse(cmd.ExecuteScalar() + "");
                this.closeConnection();
                return (count);

            }
            return (-1);

        }
        public float Avg(String command)
        {
            float avg = -1;
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(command, conn);
                avg = float.Parse(cmd.ExecuteScalar() + "");
                this.closeConnection();
                return (avg);

            }
            return (-1);

        }
    }
}
