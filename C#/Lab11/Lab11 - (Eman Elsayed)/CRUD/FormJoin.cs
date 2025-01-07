using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITI
{
    public partial class FormJoin : Form
    {
        public FormJoin()
        {
            InitializeComponent();
            LoadStudentNames();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            int studentID = Convert.ToInt32(comboBoxStudents.SelectedValue);

            string connectionString = "Server=.\\SQLEXPRESS; Database=ITI; Trusted_Connection=true; TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT c.Crs_Name AS CourseName, c.Crs_Duration AS Duration
                        FROM Stud_Course sc
                        INNER JOIN Course c ON sc.Crs_Id = c.Crs_Id
                        WHERE sc.St_Id = @StudentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);

                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dataGridView.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses: " + ex.Message);
                }
            }

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

                        comboBoxStudents.DataSource = dt;
                        comboBoxStudents.DisplayMember = "FullName";
                        comboBoxStudents.ValueMember = "St_Id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student names: " + ex.Message);
                }
            }
        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
