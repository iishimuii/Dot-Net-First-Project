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
    public partial class CategorySetupForm : Form
    {
        public CategorySetupForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = categorySetupNameTextBox.Text;
                string connectionString = @"Server =DESKTOP-O4TBSCE\SQLEXPRESS; Database = StockManagementSystemSpyCoderDb; Integrated Security = true ";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string query = @"INSERT INTO CategorySetup (Name) VALUES ('" + categoryName + "')";
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
