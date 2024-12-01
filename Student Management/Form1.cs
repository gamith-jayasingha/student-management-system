using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=studentdb;uid=root;pwd=Gamith123";

        public Form1()
        {
            InitializeComponent();
            LoadStudents();
        }

        // Load students into DataGridView
        private void LoadStudents()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM students";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewStudents.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }

        // Add student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO students (Name, Age, Contact, Gender, DateOfBirth) VALUES (@Name, @Age, @Contact, @Gender, @DateOfBirth)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student added successfully.");
                        LoadStudents();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding student: " + ex.Message);
                    }
                }
            }
        }

        // Update student
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                int studentId = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);

                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE students SET Name = @Name, Age = @Age, Contact = @Contact, Gender = @Gender, DateOfBirth = @DateOfBirth WHERE StudentID = @StudentID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student updated successfully.");
                        LoadStudents();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating student: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        // Delete student
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                int studentId = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);

                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM students WHERE StudentID = @StudentID";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student deleted successfully.");
                        LoadStudents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        // Search students
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM students WHERE Name LIKE @SearchKeyword";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewStudents.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching students: " + ex.Message);
                }
            }
        }

        // Validate input fields
        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(txtStudentName.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtContact.Text) || cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }
            return true;
        }

        // Clear input fields
        private void ClearFields()
        {
            txtStudentName.Clear();
            txtAge.Clear();
            txtContact.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDOB.ResetText();
        }
    }
}
