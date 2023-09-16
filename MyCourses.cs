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

namespace Project
{
    public partial class MyCourses : Form
    {
        public int userId;
        public MyCourses(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }


        private void CourseslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(userId);
            mainForm.ShowDialog();
        }

        private void MyCourse_Click(object sender, EventArgs e)
        {

        }

        private void MyCourses_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            DataBaseQueries.myCoursesShow(userId, MyCoursesListBox);
        }
    }




}
