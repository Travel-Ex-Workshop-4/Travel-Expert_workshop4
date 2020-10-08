namespace DesktopApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Login = new System.Windows.Forms.Label();
            this.uxLogin = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.uxPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(55, 160);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(86, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login:";
            // 
            // uxLogin
            // 
            this.uxLogin.Location = new System.Drawing.Point(137, 157);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(202, 20);
            this.uxLogin.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(55, 219);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 23);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            // 
            // uxPass
            // 
            this.uxPass.Location = new System.Drawing.Point(137, 216);
            this.uxPass.Name = "uxPass";
            this.uxPass.Size = new System.Drawing.Size(202, 20);
            this.uxPass.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(151, 298);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(91, 23);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "SignIn";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click_1);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(151, 350);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(91, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uxPass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.Login);
            this.Name = "frmLogin";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.frmLogin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox uxLogin;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox uxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btn_Exit;
    }
}

