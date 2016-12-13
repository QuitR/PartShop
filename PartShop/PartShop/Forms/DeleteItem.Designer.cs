namespace PartShop.Forms
{
    partial class DeleteItem
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
            this.Id = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Changed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(57, 12);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 0;
            this.Id.Text = "ID of item";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(57, 38);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 42);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Changed
            // 
            this.Changed.Location = new System.Drawing.Point(57, 86);
            this.Changed.Name = "Changed";
            this.Changed.Size = new System.Drawing.Size(100, 42);
            this.Changed.TabIndex = 2;
            this.Changed.Text = "Changed my mind";
            this.Changed.UseVisualStyleBackColor = true;
            this.Changed.Click += new System.EventHandler(this.Changed_Click);
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 160);
            this.Controls.Add(this.Changed);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Id);
            this.Name = "DeleteItem";
            this.Text = "DeleteItem";
            this.VisibleChanged += new System.EventHandler(this.DeleteItem_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Changed;
    }
}