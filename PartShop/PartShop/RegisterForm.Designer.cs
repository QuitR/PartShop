namespace PartShop
{
    partial class RegisterForm
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.PasswordRpt = new System.Windows.Forms.TextBox();
            this.RegistrationCmplt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(12, 12);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Enter your username...";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 64);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(123, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 38);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(123, 20);
            this.Email.TabIndex = 2;
            this.Email.Text = "E-mail";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // PasswordRpt
            // 
            this.PasswordRpt.Location = new System.Drawing.Point(12, 90);
            this.PasswordRpt.Name = "PasswordRpt";
            this.PasswordRpt.Size = new System.Drawing.Size(123, 20);
            this.PasswordRpt.TabIndex = 3;
            this.PasswordRpt.Text = "Repeat password";
            this.PasswordRpt.Click += new System.EventHandler(this.PasswordRpt_Click);
            // 
            // RegistrationCmplt
            // 
            this.RegistrationCmplt.Location = new System.Drawing.Point(12, 125);
            this.RegistrationCmplt.Name = "RegistrationCmplt";
            this.RegistrationCmplt.Size = new System.Drawing.Size(123, 61);
            this.RegistrationCmplt.TabIndex = 4;
            this.RegistrationCmplt.Text = "Complete registration";
            this.RegistrationCmplt.UseVisualStyleBackColor = true;
            this.RegistrationCmplt.Click += new System.EventHandler(this.RegistrationCmplt_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 199);
            this.Controls.Add(this.RegistrationCmplt);
            this.Controls.Add(this.PasswordRpt);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PasswordRpt;
        private System.Windows.Forms.Button RegistrationCmplt;
    }
}