namespace PartShop
{
    partial class AddItem
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
            this.Price = new System.Windows.Forms.MaskedTextBox();
            this.Make = new System.Windows.Forms.MaskedTextBox();
            this.Model = new System.Windows.Forms.MaskedTextBox();
            this.ReleaseDate = new System.Windows.Forms.MaskedTextBox();
            this.CountInStorage = new System.Windows.Forms.MaskedTextBox();
            this.CategoryName = new System.Windows.Forms.MaskedTextBox();
            this.AddAnItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(12, 12);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 1;
            this.Price.Text = "Price";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // Make
            // 
            this.Make.Location = new System.Drawing.Point(12, 38);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(100, 20);
            this.Make.TabIndex = 2;
            this.Make.Text = "Make";
            this.Make.Click += new System.EventHandler(this.Make_Click);
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(12, 64);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(100, 20);
            this.Model.TabIndex = 3;
            this.Model.Text = "Model";
            this.Model.Click += new System.EventHandler(this.Model_Click);
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Location = new System.Drawing.Point(12, 90);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.ReleaseDate.TabIndex = 4;
            this.ReleaseDate.Text = "Release date";
            this.ReleaseDate.Click += new System.EventHandler(this.ReleaseDate_Click);
            // 
            // CountInStorage
            // 
            this.CountInStorage.Location = new System.Drawing.Point(12, 116);
            this.CountInStorage.Name = "CountInStorage";
            this.CountInStorage.Size = new System.Drawing.Size(100, 20);
            this.CountInStorage.TabIndex = 5;
            this.CountInStorage.Text = "Count in storage";
            this.CountInStorage.Click += new System.EventHandler(this.CountInStorage_Click);
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(12, 142);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(100, 20);
            this.CategoryName.TabIndex = 6;
            this.CategoryName.Text = "Category id";
            this.CategoryName.Click += new System.EventHandler(this.CategoryName_Click);
            // 
            // AddAnItem
            // 
            this.AddAnItem.Location = new System.Drawing.Point(12, 170);
            this.AddAnItem.Name = "AddAnItem";
            this.AddAnItem.Size = new System.Drawing.Size(100, 46);
            this.AddAnItem.TabIndex = 7;
            this.AddAnItem.Text = "Add item";
            this.AddAnItem.UseVisualStyleBackColor = true;
            this.AddAnItem.Click += new System.EventHandler(this.AddAnItem_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 231);
            this.Controls.Add(this.AddAnItem);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.CountInStorage);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.Price);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.VisibleChanged += new System.EventHandler(this.AddItem_VisibleChanged);
            this.Click += new System.EventHandler(this.Model_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Price;
        private System.Windows.Forms.MaskedTextBox Make;
        private System.Windows.Forms.MaskedTextBox Model;
        private System.Windows.Forms.MaskedTextBox ReleaseDate;
        private System.Windows.Forms.MaskedTextBox CountInStorage;
        private System.Windows.Forms.MaskedTextBox CategoryName;
        private System.Windows.Forms.Button AddAnItem;
    }
}