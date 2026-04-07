using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get username and password from the textboxes
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            // Check if username or password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Please Enter username and password");
                return;
            }
            // Create Database connection
            DBConnect db = new DBConnect();

            try
            {
                // open database
                db.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                
                // Create MYSQL Query
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                
                // ADD parameters to prevent SQL injection 
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                
                // Execute Query and get results number
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose(); // Release Command resources

                if (count == 1 )
                {
                    MessageBox.Show("Login Successful!");
                    dashboard dashboard = new dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            
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
    }
}
