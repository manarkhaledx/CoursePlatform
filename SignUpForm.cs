using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class SignUpForm : Form
    {
        SqlCommand? cmd; // Declare cmd variable nullable
        SqlConnection cn; // Declare cn variable
        SqlDataReader? dr; // Declare dr variable nullable
        //By keeping dr as a non-nullable SqlDataReader,
        //you indicate that it will always have a non-null value when it is accessed,

        public SignUpForm()
        {
            InitializeComponent();
            //This code creates a database connection and opens it.
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\manar\source\repos\manarkhaledx\Online-Courses-Platform\DataBase.mdf"";Integrated Security=True");
            cn.Open();
        }

        public bool hasSpecialCharacter(string password)
        {
            // Define the regular expression pattern to match special characters
            string pattern = @"[^a-zA-Z0-9]";

            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Check if the password contains at least one special character
            return regex.IsMatch(password);
        }


        private void signUpButtonInSignUpForm(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    if (txtpassword.Text.Length >= 8 && hasSpecialCharacter(txtpassword.Text))
                    {
                        cmd = new SqlCommand("select * from userTable where username='" + txtusername.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SignUpForm signUpForm = new SignUpForm();
                            signUpForm.Show();
                        }
                        else
                        {
                            dr.Close();  // Closing any open SqlDataReader to avoid conflicts or resource leaks

                            // Creating a new SqlCommand object to execute an SQL INSERT statement
                            cmd = new SqlCommand("insert into userTable values(@username,@password)", cn);

                            // Adding parameters to the SqlCommand to prevent SQL injection and provide values for username and password
                            cmd.Parameters.AddWithValue("username", txtusername.Text);
                            cmd.Parameters.AddWithValue("password", txtpassword.Text);

                            // Executing the SQL INSERT statement to insert the values into the userTable
                            cmd.ExecuteNonQuery();

                            // Displaying a message box to inform the user that their account has been created successfully
                            MessageBox.Show("Your account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();  // Hiding the current form

                            // Creating a new instance of the LoginForm and displaying it as a dialog
                            LoginForm loginForm = new LoginForm();
                            loginForm.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must be at least 8 characters long and contain at least one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        SignUpForm signUpForm = new SignUpForm();
                        signUpForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the same password in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SignUpForm signUpForm = new SignUpForm();
                    signUpForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = false;
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Show();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void loginButtonInSignUpForm(object sender, EventArgs e)
        {
            this.Visible = false; // Hide the current form

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); // Show the LoginForm

        }

        private void exitButtonFromSignUpForm(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void userNameEnter(object sender, EventArgs e)
        {
            //Event
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

        private void passEnter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
            }
        }

        private void passLeave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
            }
        }

        private void confirmEnter(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text == "Confirm Password")
            {
                txtconfirmpassword.Text = "";
            }
        }

        private void confirmLeave(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text == "")
            {
                txtconfirmpassword.Text = "Confirm Password";
            }
        }
    }
}
