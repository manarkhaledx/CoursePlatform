using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Project
{

    public partial class MainForm : Form
    {

        public string DataBaseConnection;
        // Connection string to the database
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\manar\source\repos\manarkhaledx\Online-Courses-Platform\DataBase.mdf"";Integrated Security=True";
        public int userId;


        // Constructor that receives the logged-in user ID
        public MainForm(int userId)
        {

            InitializeComponent();
            this.userId = userId;

        }


        // Event handler for the main form load event
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load the user's courses when the form is loaded
            LoadUserCourses();
        }

        // Method to load the courses associated with the logged-in user
        private void LoadUserCourses()
        {

        }

        // Event handler for the logout button click event

        private void programmingPictureButton(object sender, EventArgs e)
        {
            DataBaseQueries.prepareCoursesQuery(Categories.Programming, CoursesListBox);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void businessPictureButton(object sender, EventArgs e)
        {
            DataBaseQueries.prepareCoursesQuery(Categories.Business, CoursesListBox);
        }

        private void marektingPictureButton(object sender, EventArgs e)
        {
            DataBaseQueries.prepareCoursesQuery(Categories.Marketing, CoursesListBox);
        }

        private void languagePictureButton(object sender, EventArgs e)
        {
            DataBaseQueries.prepareCoursesQuery(Categories.Languages, CoursesListBox);
        }

        private void myCoursesButton(object sender, EventArgs e)
        {

            this.Hide();
            MyCourses myCourses = new MyCourses(userId);
            myCourses.Show();

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            Process mypr;
            try
            {
                if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "Python")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/watch?v=XKHEtdqhLK8&t=2s&ab_channel=BroCode");
                }
                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "c++")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/watch?v=GQp1zzTwrIg&ab_channel=CodeBeauty");

                }
                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "Java")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/watch?v=xk4_1vDrzzo&ab_channel=BroCode");

                }

                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "BuisnessCourse")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/playlist?list=PL1O57nCUQ-e-OVRFdIB-Gu1U91yH7egmm");

                }
                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "MBA")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/watch?v=CuDTPakkhKY&list=PLrk73hIn1HcxVhjMf9BGDvDCwPI0jFE9g&ab_channel=MakeItBIG");

                }

                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "MarketingCourse")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/playlist?list=PLGffg9BcRIrARHGdWna3VTovUHfXKihpu");

                }
                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "SocialMedia")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/playlist?list=PLEiEAq2VkUUK4-Inc4LAUDeiCSLWFX2u-");

                }

                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "English")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/playlist?list=PLAie3YzOYRmley8mMYy1s9XuZYVxW1Ot7");

                }
                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "German")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/playlist?list=PLF9mJC4RrjIhS4MMm0x72-qWEn1LRvPuW");

                }
                else if (CoursesListBox.SelectedItem != null && CoursesListBox.SelectedItem.ToString() == "Arabic")
                {
                    mypr = Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"", "https://www.youtube.com/watch?v=CuDTPakkhKY&list=PLrk73hIn1HcxVhjMf9BGDvDCwPI0jFE9g&ab_channel=MakeItBIG");

                }
                else
                {
                    MessageBox.Show("You Should select a course first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error happened!");
            }
        }





        private void backButtonInMainForm(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (CoursesListBox.SelectedItem != null)
            {
                DataBaseQueries.addSubscription(userId, CoursesListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("You should select a course first!  :(");
            }

        }
    }
    public enum Categories
    {
        Programming = 1,
        Business = 2,
        Marketing = 3,
        Languages = 4,
    }

    public static class DataBaseQueries
    {
        readonly static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\manar\source\repos\manarkhaledx\Online-Courses-Platform\DataBase.mdf"";Integrated Security=True");
        static SqlCommand cmd;
        readonly static SqlDataReader dr;
        public static void myCoursesShow(int userid, ListBox listBox)
        {
            listBox.Items.Clear();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string courses = $"select * from SubscribtionTable where userId = {userid}";
            cmd.CommandText = courses;
            var results = cmd.ExecuteReader();
            while (results.Read())
            {
                listBox.Items.Add(results["courseName"]);
            }
            con.Close();
        }
        public static void prepareCoursesQuery(Categories category, ListBox listBox)
        {
            listBox.Items.Clear();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string courses = $"select * from courseTable where categoryid = {(int)category}";
            cmd.CommandText = courses;
            var results = cmd.ExecuteReader();
            while (results.Read())
            {
                listBox.Items.Add(results["courseName"]);
            }
            con.Close();
        }

        public static bool checkUserNameAvailability(string userName)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string userNames = $"select * from userTable where username = '{userName}' ";
            cmd.CommandText = userNames;
            var results = cmd.ExecuteReader();
            bool hasRows = results.HasRows;
            con.Close();
            return hasRows;
        }
        public static bool checkAddCourseAvailability(string courseName, int userid)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string userNames = $"select * from SubscribtionTable where courseName = '{courseName}' AND userId = '{userid}'";
            cmd.CommandText = userNames;
            var results = cmd.ExecuteReader();
            bool hasRows = results.HasRows;
            con.Close();
            return hasRows;
        }

        public static void addUser(string userName, string password)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string userNames = $"insert into userTable (username, password) values('{userName}', '{password}')";
            cmd.CommandText = userNames;
            cmd.ExecuteReader();
            con.Close();
        }

        public static void deleteUser(string userName)
        {
            deleteSubscriptions(getUserId(userName));
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string deleteQuery = $"delete from userTable where userName = '{userName}'";
            cmd.CommandText = deleteQuery;
            cmd.ExecuteReader();
            con.Close();
        }

        public static void editUser(string userName, string password)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string userNames = $"Update userTable Set password = '{password}' where username = '{userName}'";
            cmd.CommandText = userNames;
            cmd.ExecuteReader();
            con.Close();
        }

        private static void deleteSubscriptions(int userId)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string deleteQuery = $"delete from SubscribtionTable where userId = '{userId}'";
            cmd.CommandText = deleteQuery;
            cmd.ExecuteReader();
            con.Close();
        }

        private static int getUserId(string userName)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string userNames = $"select * from userTable where username = '{userName}'";
            cmd.CommandText = userNames;
            var results = cmd.ExecuteReader();
            int result = -1;
            while (results.Read())
            {
                result = (int)results["UserId"];
                break;
            }
            con.Close();
            return result;
        }

        public static void addSubscription(int userid, string courseName)
        {
            if (!DataBaseQueries.checkAddCourseAvailability(courseName, userid))
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                string userNames = $"insert into SubscribtionTable (courseName, userId) values('{courseName}', '{userid}')";
                cmd.CommandText = userNames;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("The course Added Successfully!");
            }
            else
            {
                MessageBox.Show("This course already existed");
            }
        }
    }
}

