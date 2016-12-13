namespace PartShop
{
    partial class AdminInterface
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
            this.CheckItems = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckItems
            // 
            this.CheckItems.Location = new System.Drawing.Point(12, 78);
            this.CheckItems.Name = "CheckItems";
            this.CheckItems.Size = new System.Drawing.Size(189, 62);
            this.CheckItems.TabIndex = 0;
            this.CheckItems.Text = "Check items";
            this.CheckItems.UseVisualStyleBackColor = true;
            this.CheckItems.Click += new System.EventHandler(this.CheckItems_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(12, 146);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(189, 62);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // EditItem
            // 
            this.EditItem.Location = new System.Drawing.Point(12, 214);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(189, 62);
            this.EditItem.TabIndex = 2;
            this.EditItem.Text = "Edit Item";
            this.EditItem.UseVisualStyleBackColor = true;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Location = new System.Drawing.Point(12, 282);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(189, 62);
            this.RemoveItem.TabIndex = 3;
            this.RemoveItem.Text = "Remove Item";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // Items
            // 
            this.Items.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.Location = new System.Drawing.Point(12, 9);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(189, 62);
            this.Items.TabIndex = 4;
            this.Items.Text = "Items";
            this.Items.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Categories
            // 
            this.Categories.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(207, 9);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(189, 62);
            this.Categories.TabIndex = 5;
            this.Categories.Text = "Categories";
            this.Categories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // Users
            // 
            this.Users.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(207, 94);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(189, 62);
            this.Users.TabIndex = 6;
            this.Users.Text = "Users";
            this.Users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(207, 270);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(189, 62);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 356);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.EditItem);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.CheckItems);
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminInterface_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckItems;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Label Items;
        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.Label Exit;
    }
}