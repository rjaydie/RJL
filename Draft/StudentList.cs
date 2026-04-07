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

namespace Draft
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });
            LoadStudents();
        }
        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();
            // Create database connection
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "SELECT * FROM students WHERE " +
                    "firstname LIKE @search " +
                    "OR lastname LIKE @search " +
                    "OR course LIKE @search " +
                    "OR section LIKE @search ";
                //Create MYSQL command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //ADD parameters
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                //Declare DataADpater for Data Table with the query results
                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                    new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                //Create a DATA Table
                System.Data.DataTable table = new System.Data.DataTable();
                //Fill Table
                adapter.Fill(table);
                dgvStudents.DataSource = table;

                //Change column headers
                dgvStudents.Columns["id"].HeaderText = "Students ID";
                dgvStudents.Columns["firstname"].HeaderText = "First Name";
                dgvStudents.Columns["lastname"].HeaderText = "Last Name";
                dgvStudents.Columns["course"].HeaderText = "Course";
                dgvStudents.Columns["section"].HeaderText = "Section";
                dgvStudents.Columns["age"].HeaderText = "Age";
                adapter.Dispose();//Reset Value after used
                cmd.Dispose();//Reset Value after used






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                //Transfer data from table to textboxes
                txtID.Text = row.Cells["id"].Value.ToString();
                txtFirstName.Text = row.Cells["firstname"].Value.ToString();
                txtLastName.Text = row.Cells["lastname"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                cmbSection.Text = row.Cells["section"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();





            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            // Declare Inputs
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            int age;
            int id;


            // Validate Inputs if Empty
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname)
                || string.IsNullOrEmpty(course) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please Fill all Field");
                return;
            }
            // Validate input for age
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter a valid age");
                return;
            }
            if (!int.TryParse(txtID.Text.Trim(), out id))
            {
                MessageBox.Show("Please Select Record");
                return;
            }

            // Call Database connection
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"UPDATE students
                    SET firstname=@firstname, 
                    lastname=@lastname, 
                    course=@course,
                    section=@section, 
                    age=@age
                    WHERE id=@id";

                //Create Command
                // Create MYSQL Query
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                // Add parameters
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                cmd.Parameters.AddWithValue("@section", cmbSection.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                txtID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                cmbCourse.SelectedIndex = 1;
                cmbSection.SelectedIndex = 1;
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            //DELETE 
            int ID;
            //Validate ID
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Click record to Delete");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to Delete this student", " Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return; //Stop process
            }
            //Create Database Connection
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "DELETE FROM students WHERE id=@id";
                // Create MYSQL Query
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Record Deleted Successfully");
                txtID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAge.Clear();
                cmbCourse.SelectedIndex = 1;
                cmbSection.SelectedIndex = 1;
                LoadStudents();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
