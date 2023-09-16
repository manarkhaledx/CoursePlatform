using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;

namespace Project
{

    public partial class LoginForm : Form
    {  //declare the fields as nullable
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Button(object sender, EventArgs e)
        {

            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open(); // Open the connection if it's not already open

                    //cn parameter represents the connection to the database
                    cmd = new SqlCommand("select * from userTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        this.Hide(); // Hide the current form
                        if (txtpassword.Text.ToLower() == "admin" && txtusername.Text.ToLower() == "admin")
                        {
                            AdminAccess form1 = new AdminAccess();
                            form1.ShowDialog();
                        }
                        else
                        {
                            MainForm mainForm = new MainForm((int)dr["userId"]); // Provide the UserId value
                            mainForm.Show();
                        }
                        cn.Close(); // Close the connection after use
                                    // Show the SandwichesForm
                                    // Add code here for the desired action when an account is found
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();
                        cn.Close(); // Close the connection after use
                        MessageBox.Show("No Account available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    cn.Close(); // Close the connection in case of an error
                    MessageBox.Show("An error occurred while executing the query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void signUpFormButton(object sender, EventArgs e)
        {
            this.Visible = false; // Hide the current form

            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show(); // Show the SignUpForm
        }

        private void exitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        { //used to establish a connection to a Microsoft SQL Server database
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\manar\source\repos\manarkhaledx\Online-Courses-Platform\DataBase.mdf"";Integrated Security=True");
            cn.Open();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userNameEnter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Text = "";
            }
        }

        private void userNameLeave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
            }
        }

        private void passwordEnter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = false;
            }

        }

        private void passwordLeave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.UseSystemPasswordChar = true;
                txtpassword.Text = "Password";
            }
        }

        private void viewPasswordIcon(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == false)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}