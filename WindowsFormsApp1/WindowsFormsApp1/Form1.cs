using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter data_adapter;
        private DataSet dataset;
        //private DataSet dataSet;
        //private String childTable = "Locationn";
        //private String parentTable = "Project";
        //private String commonField = "projectID";
        private String parentQuery = ConfigurationManager.AppSettings["parentQuery"];
        private String connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString.ToString();
        private String parentTable = ConfigurationManager.AppSettings["parentTable"];
        private String childQuery2 = ConfigurationManager.AppSettings["childQuery2"];
        private String childTable = ConfigurationManager.AppSettings["childTable"];
        private String childQuery = ConfigurationManager.AppSettings["childQuery"];
        //private String childQuery = ConfigurationManager.AppSettings["childQuery"];
        public Form1()
        {
            
            InitializeComponent();
            secondDataGrid.SelectionChanged += new EventHandler(loadLocation);
            loadProject();
        }

        private void loadProject()
        {
            //String select = "select * from Project"; 
            SqlDataAdapter projectTable = new SqlDataAdapter(ConfigurationManager.AppSettings["parentQuery"], new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString.ToString()));
            DataSet dataSet1 = new DataSet();
            projectTable.Fill(dataSet1, ConfigurationManager.AppSettings["parentTable"]);
            //projectTable.Fill(dataSet, parentTable);
            secondDataGrid.DataSource = dataSet1.Tables[ConfigurationManager.AppSettings["parentTable"]];
        }

        private void loadLocation(object sender, EventArgs e)
        {
            loadDataFromChildForEveryParent();
        }

        private void loadDataFromChildForEveryParent()
        {
            int projectID = Convert.ToInt32(secondDataGrid.CurrentRow.Cells[0].Value);
            //String select = "select * from Locationn where projectID=@id";

            SqlCommand command = new SqlCommand(ConfigurationManager.AppSettings["childQuery2"])
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString.ToString())
            };
            command.Parameters.AddWithValue("@id", projectID);
            data_adapter = new SqlDataAdapter(command);
            dataset = new DataSet();
            data_adapter.Fill(dataset, ConfigurationManager.AppSettings["childTable"]);
            firstDataGrid.DataSource = dataset.Tables[ConfigurationManager.AppSettings["childTable"]];

        }

      

        private void viewButtonClick(object sender, EventArgs e)
        {
            //String select = "select * from Locationn";
            data_adapter = new SqlDataAdapter(ConfigurationManager.AppSettings["childQuery"], ConfigurationManager.ConnectionStrings["connection"].ConnectionString.ToString());
            dataset = new DataSet();
            data_adapter.Fill(dataset, ConfigurationManager.AppSettings["childTable"]);
            firstDataGrid.DataSource = dataset.Tables[ConfigurationManager.AppSettings["childTable"]];
        }

        private void updateButtonClick(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder command = new SqlCommandBuilder(data_adapter);
                data_adapter.Update(this.dataset, ConfigurationManager.AppSettings["childTable"]);
                MessageBox.Show("Successfully updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is : "+ ex);
            }
        }

        

    }
}