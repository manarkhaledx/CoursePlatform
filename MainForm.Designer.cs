namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            WelcomePanel = new Panel();
            label1 = new Label();
            programmingpictureBox = new PictureBox();
            label2 = new Label();
            CoursesListBox = new ListBox();
            BusinesspictureBox = new PictureBox();
            MarektingpictureBox = new PictureBox();
            LanguagepictureBox = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            viewbutton = new Button();
            Exitbutton = new Button();
            button1 = new Button();
            BackToLogin = new Button();
            Add = new Button();
            WelcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)programmingpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BusinesspictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MarektingpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LanguagepictureBox).BeginInit();
            SuspendLayout();
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.FromArgb(165, 64, 213);
            WelcomePanel.Controls.Add(label1);
            WelcomePanel.Dock = DockStyle.Top;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Margin = new Padding(1);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(997, 95);
            WelcomePanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(415, 32);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 29);
            label1.TabIndex = 0;
            label1.Text = "Our Courses";
            label1.Click += label1_Click;
            // 
            // programmingpictureBox
            // 
            programmingpictureBox.Image = (Image)resources.GetObject("programmingpictureBox.Image");
            programmingpictureBox.Location = new Point(91, 120);
            programmingpictureBox.Margin = new Padding(3, 4, 3, 4);
            programmingpictureBox.Name = "programmingpictureBox";
            programmingpictureBox.Size = new Size(120, 120);
            programmingpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            programmingpictureBox.TabIndex = 8;
            programmingpictureBox.TabStop = false;
            programmingpictureBox.Click += programmingPictureButton;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 64, 213);
            label2.Location = new Point(79, 265);
            label2.Name = "label2";
            label2.Size = new Size(160, 29);
            label2.TabIndex = 9;
            label2.Text = "Programming";
            // 
            // CoursesListBox
            // 
            CoursesListBox.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CoursesListBox.ForeColor = Color.FromArgb(165, 64, 213);
            CoursesListBox.FormattingEnabled = true;
            CoursesListBox.ItemHeight = 29;
            CoursesListBox.Location = new Point(343, 345);
            CoursesListBox.Margin = new Padding(3, 4, 3, 4);
            CoursesListBox.Name = "CoursesListBox";
            CoursesListBox.Size = new Size(285, 149);
            CoursesListBox.TabIndex = 10;
            CoursesListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BusinesspictureBox
            // 
            BusinesspictureBox.Image = (Image)resources.GetObject("BusinesspictureBox.Image");
            BusinesspictureBox.Location = new Point(309, 120);
            BusinesspictureBox.Margin = new Padding(3, 4, 3, 4);
            BusinesspictureBox.Name = "BusinesspictureBox";
            BusinesspictureBox.Size = new Size(131, 120);
            BusinesspictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BusinesspictureBox.TabIndex = 12;
            BusinesspictureBox.TabStop = false;
            BusinesspictureBox.Click += businessPictureButton;
            // 
            // MarektingpictureBox
            // 
            MarektingpictureBox.Image = (Image)resources.GetObject("MarektingpictureBox.Image");
            MarektingpictureBox.Location = new Point(537, 120);
            MarektingpictureBox.Margin = new Padding(3, 4, 3, 4);
            MarektingpictureBox.Name = "MarektingpictureBox";
            MarektingpictureBox.Size = new Size(109, 120);
            MarektingpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MarektingpictureBox.TabIndex = 13;
            MarektingpictureBox.TabStop = false;
            MarektingpictureBox.Click += marektingPictureButton;
            // 
            // LanguagepictureBox
            // 
            LanguagepictureBox.Image = (Image)resources.GetObject("LanguagepictureBox.Image");
            LanguagepictureBox.Location = new Point(743, 120);
            LanguagepictureBox.Margin = new Padding(3, 4, 3, 4);
            LanguagepictureBox.Name = "LanguagepictureBox";
            LanguagepictureBox.Size = new Size(105, 120);
            LanguagepictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LanguagepictureBox.TabIndex = 14;
            LanguagepictureBox.TabStop = false;
            LanguagepictureBox.Click += languagePictureButton;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 64, 213);
            label3.Location = new Point(323, 265);
            label3.Name = "label3";
            label3.Size = new Size(109, 29);
            label3.TabIndex = 15;
            label3.Text = "Business";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 64, 213);
            label4.Location = new Point(537, 265);
            label4.Name = "label4";
            label4.Size = new Size(121, 29);
            label4.TabIndex = 16;
            label4.Text = "Marketing";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 64, 213);
            label5.Location = new Point(743, 265);
            label5.Name = "label5";
            label5.Size = new Size(130, 29);
            label5.TabIndex = 17;
            label5.Text = "Languages";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(165, 64, 213);
            label6.Location = new Point(79, 345);
            label6.Name = "label6";
            label6.Size = new Size(188, 29);
            label6.TabIndex = 18;
            label6.Text = "Choose courses:";
            // 
            // viewbutton
            // 
            viewbutton.BackColor = Color.FromArgb(165, 64, 213);
            viewbutton.FlatStyle = FlatStyle.Flat;
            viewbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewbutton.ForeColor = Color.White;
            viewbutton.Location = new Point(679, 368);
            viewbutton.Margin = new Padding(3, 4, 3, 4);
            viewbutton.Name = "viewbutton";
            viewbutton.Size = new Size(129, 52);
            viewbutton.TabIndex = 19;
            viewbutton.Text = "View";
            viewbutton.UseVisualStyleBackColor = false;
            viewbutton.Click += viewButton_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.FromArgb(165, 64, 213);
            Exitbutton.FlatStyle = FlatStyle.Flat;
            Exitbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Exitbutton.ForeColor = Color.White;
            Exitbutton.Location = new Point(679, 445);
            Exitbutton.Margin = new Padding(3, 4, 3, 4);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(129, 52);
            Exitbutton.TabIndex = 20;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += exitButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(165, 64, 213);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(743, 561);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(221, 52);
            button1.TabIndex = 21;
            button1.Text = "My Courses";
            button1.UseVisualStyleBackColor = false;
            button1.Click += myCoursesButton;
            // 
            // BackToLogin
            // 
            BackToLogin.BackColor = Color.FromArgb(165, 64, 213);
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackToLogin.ForeColor = Color.White;
            BackToLogin.Location = new Point(43, 569);
            BackToLogin.Margin = new Padding(3, 4, 3, 4);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(221, 52);
            BackToLogin.TabIndex = 22;
            BackToLogin.Text = "Back To Login";
            BackToLogin.UseVisualStyleBackColor = false;
            BackToLogin.Click += backButtonInMainForm;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(165, 64, 213);
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = Color.White;
            Add.Location = new Point(435, 561);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(129, 52);
            Add.TabIndex = 23;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += add_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(997, 660);
            Controls.Add(Add);
            Controls.Add(BackToLogin);
            Controls.Add(button1);
            Controls.Add(Exitbutton);
            Controls.Add(viewbutton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LanguagepictureBox);
            Controls.Add(MarektingpictureBox);
            Controls.Add(BusinesspictureBox);
            Controls.Add(CoursesListBox);
            Controls.Add(label2);
            Controls.Add(programmingpictureBox);
            Controls.Add(WelcomePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)programmingpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BusinesspictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MarektingpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LanguagepictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel WelcomePanel;
        private Label label1;
        private PictureBox programmingpictureBox;
        private Label label2;
        private ListBox CoursesListBox;
        private PictureBox BusinesspictureBox;
        private PictureBox MarektingpictureBox;
        private PictureBox LanguagepictureBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button viewbutton;
        private Button Exitbutton;
        private Button button1;
        private Button BackToLogin;
        private LinkLabel linkLabel1;
        private Button Add;
    }
}