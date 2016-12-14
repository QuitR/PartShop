namespace PartShop.Forms
{
    partial class ShoppingCart
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
            this.components = new System.ComponentModel.Container();
            this.databaseDataSet = new PartShop.DatabaseDataSet();
            this.boughtStuffSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boughtStuffSetTableAdapter = new PartShop.DatabaseDataSetTableAdapters.BoughtStuffSetTableAdapter();
            this.tableAdapterManager = new PartShop.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.boughtStuffSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boughtStuffSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boughtStuffSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boughtStuffSetBindingSource
            // 
            this.boughtStuffSetBindingSource.DataMember = "BoughtStuffSet";
            this.boughtStuffSetBindingSource.DataSource = this.databaseDataSet;
            // 
            // boughtStuffSetTableAdapter
            // 
            this.boughtStuffSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoughtStuffSetTableAdapter = this.boughtStuffSetTableAdapter;
            this.tableAdapterManager.CategorySetTableAdapter = null;
            this.tableAdapterManager.ItemSetTableAdapter = null;
            this.tableAdapterManager.ProductSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PartShop.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserSetTableAdapter = null;
            // 
            // boughtStuffSetDataGridView
            // 
            this.boughtStuffSetDataGridView.AllowUserToAddRows = false;
            this.boughtStuffSetDataGridView.AllowUserToDeleteRows = false;
            this.boughtStuffSetDataGridView.AutoGenerateColumns = false;
            this.boughtStuffSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boughtStuffSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.boughtStuffSetDataGridView.DataSource = this.boughtStuffSetBindingSource;
            this.boughtStuffSetDataGridView.Location = new System.Drawing.Point(12, 12);
            this.boughtStuffSetDataGridView.Name = "boughtStuffSetDataGridView";
            this.boughtStuffSetDataGridView.ReadOnly = true;
            this.boughtStuffSetDataGridView.Size = new System.Drawing.Size(550, 220);
            this.boughtStuffSetDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn3.HeaderText = "Make";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ReleaseDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "ReleaseDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Back
            // 
            this.Back.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Back.Location = new System.Drawing.Point(593, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(55, 47);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 280);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.boughtStuffSetDataGridView);
            this.Name = "ShoppingCart";
            this.Text = "Items I have bought";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            this.VisibleChanged += new System.EventHandler(this.ShoppingCart_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boughtStuffSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boughtStuffSetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource boughtStuffSetBindingSource;
        private DatabaseDataSetTableAdapters.BoughtStuffSetTableAdapter boughtStuffSetTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView boughtStuffSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Back;
    }
}