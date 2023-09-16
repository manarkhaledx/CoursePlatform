namespace Project
{
    partial class AdminAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccess));
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            DeletePictureBox = new PictureBox();
            EditpictureBox = new PictureBox();
            AddpictureBox = new PictureBox();
            password = new TextBox();
            UserName = new TextBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            Backbutton = new Button();
            WelcomePanel = new Panel();
            label5 = new Label();
            exitbutton = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DeletePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            WelcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 64, 213);
            label3.Location = new Point(497, 269);
            label3.Name = "label3";
            label3.Size = new Size(83, 29);
            label3.TabIndex = 61;
            label3.Text = "Delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(165, 64, 213);
            label1.Location = new Point(859, 269);
            label1.Name = "label1";
            label1.Size = new Size(54, 29);
            label1.TabIndex = 60;
            label1.Text = "Edit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 64, 213);
            label2.Location = new Point(203, 269);
            label2.Name = "label2";
            label2.Size = new Size(55, 29);
            label2.TabIndex = 59;
            label2.Text = "Add";
            // 
            // DeletePictureBox
            // 
            DeletePictureBox.Image = (Image)resources.GetObject("DeletePictureBox.Image");
            DeletePictureBox.Location = new Point(466, 123);
            DeletePictureBox.Margin = new Padding(3, 4, 3, 4);
            DeletePictureBox.Name = "DeletePictureBox";
            DeletePictureBox.Size = new Size(128, 128);
            DeletePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            DeletePictureBox.TabIndex = 57;
            DeletePictureBox.TabStop = false;
            DeletePictureBox.Click += deletePictureButton;
            // 
            // EditpictureBox
            // 
            EditpictureBox.Image = (Image)resources.GetObject("EditpictureBox.Image");
            EditpictureBox.Location = new Point(823, 123);
            EditpictureBox.Margin = new Padding(3, 4, 3, 4);
            EditpictureBox.Name = "EditpictureBox";
            EditpictureBox.Size = new Size(128, 128);
            EditpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EditpictureBox.TabIndex = 56;
            EditpictureBox.TabStop = false;
            EditpictureBox.Click += editPictureButton;
            // 
            // AddpictureBox
            // 
            AddpictureBox.Image = (Image)resources.GetObject("AddpictureBox.Image");
            AddpictureBox.Location = new Point(169, 123);
            AddpictureBox.Margin = new Padding(3, 4, 3, 4);
            AddpictureBox.Name = "AddpictureBox";
            AddpictureBox.Size = new Size(128, 128);
            AddpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AddpictureBox.TabIndex = 55;
            AddpictureBox.TabStop = false;
            AddpictureBox.Click += addPictureBox;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor = Color.FromArgb(165, 64, 213);
            password.Location = new Point(423, 423);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(234, 31);
            password.TabIndex = 53;
            password.Text = "Password";
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            password.Enter += pass_Enter;
            password.Leave += pass_Leave;
            // 
            // UserName
            // 
            UserName.BorderStyle = BorderStyle.None;
            UserName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.ForeColor = Color.FromArgb(165, 64, 213);
            UserName.Location = new Point(423, 353);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(234, 31);
            UserName.TabIndex = 52;
            UserName.Text = "Username";
            UserName.TextChanged += userName_TextChanged;
            UserName.Enter += userName_Enter;
            UserName.Leave += userName_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(387, 423);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(218, 167, 234);
            panel3.Location = new Point(0, 17);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 1);
            panel3.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(218, 167, 234);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(387, 459);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 1);
            panel2.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 167, 234);
            panel1.Location = new Point(387, 389);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 1);
            panel1.TabIndex = 47;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(387, 353);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // Backbutton
            // 
            Backbutton.BackColor = Color.FromArgb(165, 64, 213);
            Backbutton.FlatStyle = FlatStyle.Flat;
            Backbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Backbutton.ForeColor = Color.White;
            Backbutton.Location = new Point(31, 516);
            Backbutton.Margin = new Padding(3, 4, 3, 4);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(129, 52);
            Backbutton.TabIndex = 63;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += backButton_Click_1;
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.FromArgb(165, 64, 213);
            WelcomePanel.Controls.Add(label5);
            WelcomePanel.Dock = DockStyle.Top;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Margin = new Padding(1);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(1019, 95);
            WelcomePanel.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(415, 32);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 29);
            label5.TabIndex = 0;
            label5.Text = "Admin Control";
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.FromArgb(165, 64, 213);
            exitbutton.FlatStyle = FlatStyle.Flat;
            exitbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitbutton.ForeColor = Color.White;
            exitbutton.Location = new Point(859, 516);
            exitbutton.Margin = new Padding(3, 4, 3, 4);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(129, 52);
            exitbutton.TabIndex = 65;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exit_Button;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(629, 423);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            pictureBox2.Click += viewButton;
            // 
            // AdminAccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 599);
            Controls.Add(pictureBox2);
            Controls.Add(exitbutton);
            Controls.Add(WelcomePanel);
            Controls.Add(Backbutton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(DeletePictureBox);
            Controls.Add(EditpictureBox);
            Controls.Add(AddpictureBox);
            Controls.Add(password);
            Controls.Add(UserName);
            Controls.Add(pictureBox4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "AdminAccess";
            Text = "Form1";
            Load += adminAccess_Load;
            ((System.ComponentModel.ISupportInitialize)DeletePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox DeletePictureBox;
        private PictureBox EditpictureBox;
        private PictureBox AddpictureBox;
        private TextBox password;
        private TextBox UserName;
        private PictureBox pictureBox4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Button Backbutton;
        private Panel WelcomePanel;
        private Label label5;
        private Button exitbutton;
        private PictureBox pictureBox2;
    }
}