namespace PartShop
{
    partial class UserInterface
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
            this.Buy = new System.Windows.Forms.Button();
            this.Bought = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.MostPopular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.SystemColors.Info;
            this.Buy.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy.Location = new System.Drawing.Point(13, 13);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(167, 48);
            this.Buy.TabIndex = 0;
            this.Buy.Text = "Buy an item";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Bought
            // 
            this.Bought.BackColor = System.Drawing.SystemColors.Info;
            this.Bought.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bought.Location = new System.Drawing.Point(12, 67);
            this.Bought.Name = "Bought";
            this.Bought.Size = new System.Drawing.Size(167, 57);
            this.Bought.TabIndex = 2;
            this.Bought.Text = "Items I have bought";
            this.Bought.UseVisualStyleBackColor = false;
            this.Bought.Click += new System.EventHandler(this.Bought_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.Info;
            this.Logout.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(13, 193);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(167, 57);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MostPopular
            // 
            this.MostPopular.BackColor = System.Drawing.SystemColors.Info;
            this.MostPopular.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostPopular.Location = new System.Drawing.Point(13, 130);
            this.MostPopular.Name = "MostPopular";
            this.MostPopular.Size = new System.Drawing.Size(167, 57);
            this.MostPopular.TabIndex = 4;
            this.MostPopular.Text = "Most popular";
            this.MostPopular.UseVisualStyleBackColor = false;
            this.MostPopular.Click += new System.EventHandler(this.MostPopular_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 261);
            this.Controls.Add(this.MostPopular);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Bought);
            this.Controls.Add(this.Buy);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.VisibleChanged += new System.EventHandler(this.UserInterface_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Button Bought;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button MostPopular;
    }
}