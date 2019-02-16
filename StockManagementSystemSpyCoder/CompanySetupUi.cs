using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemSpyCoder
{
    public partial class CompanySetupUi : Form
    {
        public CompanySetupUi()
        {
            InitializeComponent();
        }

        private void CompanySetupSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string companyName = companySetupNameTextBox.Text;
                string connectionString = @"Server =DESKTOP-O4TBSCE\SQLEXPRESS; Database = StockManagementSystemSpyCoderDb; Integrated Security = true ";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string query = @"INSERT INTO CompanySetup (Name) VALUES ('" + companyName + "')";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
                //8
                sqlConnection.Close();

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }

        
    }
}
