using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program p = new Program();
            if(p.ConnectDB()==true)
            {
                Console.ReadLine();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else {
                Console.ReadLine();
            }
            
        }

        private  String getConnection()
        {
            return "Server=LAPTOP-G5KKT640\\SQLEXPRESS;" + "Database=24VolunteerDataBase;" + "Integrated Security = true;";
        }
     
        public bool ConnectDB()
        {

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(getConnection());
                connection.Open();
                Console.WriteLine("Successfully connected to db!");
                Console.WriteLine(connection.ConnectionTimeout);
                Console.WriteLine(connection.ConnectionString);


                //read data from drug table based on sql command and sql data reader
                String selectStatement = "select * from Project";
                SqlCommand command = new SqlCommand(selectStatement, connection);
                // Console.WriteLine(command.ExecuteScalar());

                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader["projectID"] + " " + dataReader["PName"]);

                    // Console.WriteLine(dataReader.GetInt32(0) + " " + dataReader.GetValue(1));

                }
                return true;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not conenct to the db " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}