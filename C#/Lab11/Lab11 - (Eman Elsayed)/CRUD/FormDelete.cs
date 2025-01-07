using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITI
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
            LoadStudentNames();
        }

        private void ClearFields()
        {
            st_id.Clear();
            fname.Clear();
            lname.Clear();
            address.Clear();
            age.Clear();
        }

        private void LoadStudentNames()
        {
            string connectionString = "Server=.\\SQLEXPRESS; Database=ITI; Trusted_Connection=true; TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT St_Id, St_Fname + ' ' + St_Lname AS FullName FROM Student";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "FullName";
                        comboBox1.ValueMember = "St_Id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {fname.Text} {lname.Text}?",
                "Warning!!!",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string connectionString = "Server=.\\SQLEXPRESS; Database=ITI; Trusted_Connection=true; TrustServerCertificate=true";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    SqlCommand deleteStudentCoursesCommand = new SqlCommand();
                    SqlCommand deleteStudentCommand = new SqlCommand();

                    deleteStudentCoursesCommand.CommandType = CommandType.Text;
                    deleteStudentCommand.CommandType = CommandType.Text;

                    deleteStudentCoursesCommand.CommandText = "DELETE FROM Stud_Course WHERE St_Id = @ID";
                    deleteStudentCoursesCommand.Parameters.AddWithValue("@ID", st_id.Text);

                    deleteStudentCommand.CommandText = "DELETE FROM Student WHERE St_Id = @ID";
                    deleteStudentCommand.Parameters.AddWithValue("@ID", st_id.Text);

                    deleteStudentCoursesCommand.Connection = sqlConnection;
                    deleteStudentCommand.Connection = sqlConnection;

                    try
                    {
                        sqlConnection.Open();

                        deleteStudentCoursesCommand.ExecuteNonQuery();

                        int rowsAffected = deleteStudentCommand.ExecuteNonQuery();

                        MessageBox.Show($"{rowsAffected} row(s) deleted successfully.");

                        ClearFields();
                        LoadStudentNames();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string connectionString = "Server=.\\SQLEXPRESS; Database=ITI; Trusted_Connection=true; TrustServerCertificate=true";

            if (comboBox1.SelectedValue == null) return;

            int studentID = Convert.ToInt32(comboBox1.SelectedValue);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Student WHERE St_Id = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", studentID);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            st_id.Text = reader["St_Id"].ToString();
                            fname.Text = reader["St_Fname"].ToString();
                            lname.Text = reader["St_Lname"].ToString();
                            address.Text = reader["St_Address"].ToString();
                            age.Text = reader["St_Age"].ToString();

                            st_id.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.\\SQLEXPRESS; Database=ITI; Trusted_Connection=true; TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Student SET St_Fname = @FirstName, St_Lname = @LastName, St_Address = @Address, St_Age = @Age WHERE St_Id = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", int.Parse(st_id.Text));
                        command.Parameters.AddWithValue("@FirstName", fname.Text);
                        command.Parameters.AddWithValue("@LastName", lname.Text);
                        command.Parameters.AddWithValue("@Address", address.Text);
                        command.Parameters.AddWithValue("@Age", int.Parse(age.Text));

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) updated successfully.");
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
