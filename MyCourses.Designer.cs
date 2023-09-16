namespace Project
{
    partial class MyCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCourses));
            WelcomePanel = new Panel();
            MyCourse = new Label();
            Exitbutton = new Button();
            Backbutton = new Button();
            AvaliableCourses = new Label();
            MyCoursesListBox = new ListBox();
            Show = new Button();
            WelcomePanel.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.FromArgb(165, 64, 213);
            WelcomePanel.Controls.Add(MyCourse);
            WelcomePanel.Dock = DockStyle.Top;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Margin = new Padding(1);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(1030, 95);
            WelcomePanel.TabIndex = 4;
            // 
            // MyCourse
            // 
            MyCourse.AutoSize = true;
            MyCourse.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MyCourse.ForeColor = Color.White;
            MyCourse.Location = new Point(415, 32);
            MyCourse.Margin = new Padding(1, 0, 1, 0);
            MyCourse.Name = "MyCourse";
            MyCourse.Size = new Size(138, 29);
            MyCourse.TabIndex = 0;
            MyCourse.Text = "My Courses";
            MyCourse.Click += MyCourse_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.FromArgb(165, 64, 213);
            Exitbutton.FlatStyle = FlatStyle.Flat;
            Exitbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Exitbutton.ForeColor = Color.White;
            Exitbutton.Location = new Point(763, 567);
            Exitbutton.Margin = new Padding(3, 4, 3, 4);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(129, 52);
            Exitbutton.TabIndex = 25;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += exitButton_Click;
            // 
            // Backbutton
            // 
            Backbutton.BackColor = Color.FromArgb(165, 64, 213);
            Backbutton.FlatStyle = FlatStyle.Flat;
            Backbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Backbutton.ForeColor = Color.White;
            Backbutton.Location = new Point(129, 567);
            Backbutton.Margin = new Padding(3, 4, 3, 4);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(129, 52);
            Backbutton.TabIndex = 24;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += backButton_Click;
            // 
            // AvaliableCourses
            // 
            AvaliableCourses.AutoSize = true;
            AvaliableCourses.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AvaliableCourses.ForeColor = Color.FromArgb(165, 64, 213);
            AvaliableCourses.Location = new Point(10, 115);
            AvaliableCourses.Name = "AvaliableCourses";
            AvaliableCourses.Size = new Size(207, 29);
            AvaliableCourses.TabIndex = 23;
            AvaliableCourses.Text = "Your Courses are: ";
            // 
            // MyCoursesListBox
            // 
            MyCoursesListBox.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MyCoursesListBox.ForeColor = Color.FromArgb(165, 64, 213);
            MyCoursesListBox.FormattingEnabled = true;
            MyCoursesListBox.ItemHeight = 29;
            MyCoursesListBox.Location = new Point(241, 115);
            MyCoursesListBox.Margin = new Padding(3, 4, 3, 4);
            MyCoursesListBox.Name = "MyCoursesListBox";
            MyCoursesListBox.Size = new Size(541, 294);
            MyCoursesListBox.TabIndex = 22;
            MyCoursesListBox.SelectedIndexChanged += CourseslistBox_SelectedIndexChanged;
            // 
            // Show
            // 
            Show.BackColor = Color.FromArgb(165, 64, 213);
            Show.FlatStyle = FlatStyle.Flat;
            Show.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Show.ForeColor = Color.White;
            Show.Location = new Point(443, 472);
            Show.Margin = new Padding(3, 4, 3, 4);
            Show.Name = "Show";
            Show.Size = new Size(129, 52);
            Show.TabIndex = 26;
            Show.Text = "Show";
            Show.UseVisualStyleBackColor = false;
            Show.Click += show_Click;
            // 
            // MyCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 627);
            Controls.Add(Show);
            Controls.Add(Exitbutton);
            Controls.Add(Backbutton);
            Controls.Add(AvaliableCourses);
            Controls.Add(MyCoursesListBox);
            Controls.Add(WelcomePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "MyCourses";
            Text = "Form1";
            Load += MyCourses_Load;
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel WelcomePanel;
        private Label MyCourse;
        private Button Exitbutton;
        private Button Backbutton;
        private Label AvaliableCourses;
        private ListBox MyCoursesListBox;
        private Button Show;
    }
}