namespace PartShop.Forms
{
    partial class EditItem
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
            this.CountInStorage = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Make = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.CategoryId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountInStorage
            // 
            this.CountInStorage.Location = new System.Drawing.Point(13, 147);
            this.CountInStorage.Name = "CountInStorage";
            this.CountInStorage.Size = new System.Drawing.Size(100, 20);
            this.CountInStorage.TabIndex = 0;
            this.CountInStorage.Text = "Count in storage";
            this.CountInStorage.Click += new System.EventHandler(this.CountInStorage_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(13, 40);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 1;
            this.Price.Text = "Price";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // Make
            // 
            this.Make.Location = new System.Drawing.Point(13, 67);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(100, 20);
            this.Make.TabIndex = 2;
            this.Make.Text = "Make";
            this.Make.Click += new System.EventHandler(this.Make_Click);
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(13, 94);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(100, 20);
            this.Model.TabIndex = 3;
            this.Model.Text = "Model";
            this.Model.Click += new System.EventHandler(this.Model_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(13, 121);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // CategoryId
            // 
            this.CategoryId.Location = new System.Drawing.Point(13, 173);
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Size = new System.Drawing.Size(100, 20);
            this.CategoryId.TabIndex = 5;
            this.CategoryId.Text = "Category";
            this.CategoryId.Click += new System.EventHandler(this.CategoryId_Click);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(13, 14);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 6;
            this.Id.Text = "ID of item";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(12, 210);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(101, 42);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 266);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.CategoryId);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CountInStorage);
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountInStorage;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Make;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox CategoryId;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button Edit;
    }
}