using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITI
{
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.\\SQLEXPRESS; Database = ITI; Trusted_Connection = true; TrustServerCertificate = true";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var query = "insert into Student (St_Id , St_Fname , St_Lname , St_Address , St_Age) values(@ID , @FName , @LName ,@Address ,@Age )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", int.Parse(st_id.Text));
                        command.Parameters.AddWithValue("@FName", fname.Text);
                        command.Parameters.AddWithValue("@LName", lname.Text);
                        command.Parameters.AddWithValue("@Address", address.Text);
                        command.Parameters.AddWithValue("@Age", int.Parse(age.Text));

                        ResText.Text = $"{command.ExecuteNonQuery()} row(s) inserted successfully.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    
    }
}
