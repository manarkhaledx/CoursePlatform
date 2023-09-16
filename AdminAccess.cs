using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminAccess : Form
    {
        public AdminAccess()
        {
            InitializeComponent();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void addPictureBox(object sender, EventArgs e)
        {
            bool userAvailability = DataBaseQueries.checkUserNameAvailability(this.UserName.Text);
            if (!userAvailability)
            { // Username is available, add the new user

                DataBaseQueries.addUser(this.UserName.Text, this.password.Text);
                MessageBox.Show("Username added successfully");
            }
            else
            {

                // Username is not available, display an error message or take appropriate action
                MessageBox.Show("Username already exists. Please choose a different username.");
            }
        }

        private void deletePictureButton(object sender, EventArgs e)
        {
            bool userAvailability = DataBaseQueries.checkUserNameAvailability(this.UserName.Text);
            if (!userAvailability)
            { // Username is available, add the new user

                MessageBox.Show("Username not found");
            }
            else
            {
                DataBaseQueries.deleteUser(this.UserName.Text);
                // Username is not available, display an error message or take appropriate action
                MessageBox.Show("Username deleted successfully");
            }

        }

        private void editPictureButton(object sender, EventArgs e)
        {
            bool userAvailability = DataBaseQueries.checkUserNameAvailability(this.UserName.Text);
            if (!userAvailability)
            { // Username is available, add the new user

                MessageBox.Show("Username not found");
            }
            else
            {
                DataBaseQueries.editUser(this.UserName.Text, this.password.Text);
                // Username is not available, display an error message or take appropriate action
                MessageBox.Show("Username Edited successfully");
            }

        }


        private void adminAccess_Load(object sender, EventArgs e)
        {

        }

        private void exit_Button(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "Username")
            {
                UserName.Text = "";
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Text = "Username";
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.UseSystemPasswordChar = false;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.UseSystemPasswordChar = true;
                password.Text = "Password";
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewButton(object sender, EventArgs e)
        {
            if (password.UseSystemPasswordChar == false)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }
    }
}
