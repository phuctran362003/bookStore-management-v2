namespace BookManagement_PhucTG
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            lblHeading = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnSignIn = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            lblSubHeading = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblHeading);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 80);
            panel1.TabIndex = 0;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.BackColor = SystemColors.HotTrack;
            lblHeading.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = SystemColors.ButtonFace;
            lblHeading.Location = new Point(0, 18);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(300, 41);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Book Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnSignIn);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(lblSubHeading);
            panel2.Location = new Point(82, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 478);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 119);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.HotTrack;
            btnSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(50, 364);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(199, 40);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightGray;
            txtPassword.Location = new Point(50, 305);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(199, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.Location = new Point(50, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.HotTrack;
            lblEmail.Location = new Point(50, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.HotTrack;
            lblPassword.Location = new Point(50, 282);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.FlatStyle = FlatStyle.Flat;
            lblSubHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubHeading.ForeColor = SystemColors.HotTrack;
            lblSubHeading.Location = new Point(15, 147);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(272, 41);
            lblSubHeading.TabIndex = 1;
            lblSubHeading.Text = "Please Log In First";
            // 
            // LoginForm
            // 
            AcceptButton = btnSignIn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(464, 576);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Log In";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblHeading;
        private Panel panel2;
        private Button btnSignIn;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblSubHeading;
        private PictureBox pictureBox1;
    }
}