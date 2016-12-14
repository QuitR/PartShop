namespace PartShop.Forms
{
    partial class BuyItem
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
            this.itemSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemSetTableAdapter = new PartShop.DatabaseDataSetTableAdapters.ItemSetTableAdapter();
            this.tableAdapterManager = new PartShop.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.itemSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.TextBox();
            this.Purchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemSetBindingSource
            // 
            this.itemSetBindingSource.DataMember = "ItemSet";
            this.itemSetBindingSource.DataSource = this.databaseDataSet;
            // 
            // itemSetTableAdapter
            // 
            this.itemSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorySetTableAdapter = null;
            this.tableAdapterManager.ItemSetTableAdapter = this.itemSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = PartShop.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserSetTableAdapter = null;
            // 
            // itemSetDataGridView
            // 
            this.itemSetDataGridView.AllowUserToAddRows = false;
            this.itemSetDataGridView.AllowUserToDeleteRows = false;
            this.itemSetDataGridView.AutoGenerateColumns = false;
            this.itemSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.itemSetDataGridView.DataSource = this.itemSetBindingSource;
            this.itemSetDataGridView.Location = new System.Drawing.Point(12, 12);
            this.itemSetDataGridView.Name = "itemSetDataGridView";
            this.itemSetDataGridView.ReadOnly = true;
            this.itemSetDataGridView.Size = new System.Drawing.Size(653, 315);
            this.itemSetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CountInStorage";
            this.dataGridViewTextBoxColumn5.HeaderText = "Number of items in storage";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ReleaseDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Release Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ItemId
            // 
            this.ItemId.Location = new System.Drawing.Point(706, 70);
            this.ItemId.Name = "ItemId";
            this.ItemId.Size = new System.Drawing.Size(111, 20);
            this.ItemId.TabIndex = 1;
            this.ItemId.Text = "Item ID";
            this.ItemId.Click += new System.EventHandler(this.ItemId_Click);
            // 
            // Purchase
            // 
            this.Purchase.BackColor = System.Drawing.Color.Lime;
            this.Purchase.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Purchase.Location = new System.Drawing.Point(706, 96);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(111, 60);
            this.Purchase.TabIndex = 2;
            this.Purchase.Text = "Purchase item";
            this.Purchase.UseVisualStyleBackColor = false;
            this.Purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // BuyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 389);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.itemSetDataGridView);
            this.Name = "BuyItem";
            this.Text = "BuyItem";
            this.Load += new System.EventHandler(this.BuyItem_Load);
            this.VisibleChanged += new System.EventHandler(this.BuyItem_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource itemSetBindingSource;
        private DatabaseDataSetTableAdapters.ItemSetTableAdapter itemSetTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView itemSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox ItemId;
        private System.Windows.Forms.Button Purchase;
    }
}