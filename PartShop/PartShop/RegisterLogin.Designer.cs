using System;

namespace PartShop
{
    partial class RegisterLogin
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

            this.Register = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 30);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(126, 54);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(146, 30);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(126, 54);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Name = "LoginRegister";
            this.Text = "Register/Login";
            this.ResumeLayout(false);
            
        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Login;
    }
}

