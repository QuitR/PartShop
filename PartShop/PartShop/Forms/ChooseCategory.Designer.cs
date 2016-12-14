namespace PartShop.Forms
{
    partial class ChooseCategory
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
            this.categorySetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorySetTableAdapter = new PartShop.DatabaseDataSetTableAdapters.CategorySetTableAdapter();
            this.tableAdapterManager = new PartShop.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.categorySetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryChoose = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorySetBindingSource
            // 
            this.categorySetBindingSource.DataMember = "CategorySet";
            this.categorySetBindingSource.DataSource = this.databaseDataSet;
            // 
            // categorySetTableAdapter
            // 
            this.categorySetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorySetTableAdapter = this.categorySetTableAdapter;
            this.tableAdapterManager.ItemSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PartShop.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserSetTableAdapter = null;
            // 
            // categorySetDataGridView
            // 
            this.categorySetDataGridView.AllowUserToAddRows = false;
            this.categorySetDataGridView.AllowUserToDeleteRows = false;
            this.categorySetDataGridView.AutoGenerateColumns = false;
            this.categorySetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorySetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categorySetDataGridView.DataSource = this.categorySetBindingSource;
            this.categorySetDataGridView.Location = new System.Drawing.Point(12, 12);
            this.categorySetDataGridView.Name = "categorySetDataGridView";
            this.categorySetDataGridView.ReadOnly = true;
            this.categorySetDataGridView.Size = new System.Drawing.Size(300, 118);
            this.categorySetDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CategoryChoose
            // 
            this.CategoryChoose.Location = new System.Drawing.Point(12, 136);
            this.CategoryChoose.Multiline = true;
            this.CategoryChoose.Name = "CategoryChoose";
            this.CategoryChoose.Size = new System.Drawing.Size(157, 42);
            this.CategoryChoose.TabIndex = 2;
            this.CategoryChoose.Text = "Enter category name..";
            this.CategoryChoose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CategoryChoose.Click += new System.EventHandler(this.CategoryChoose_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Lime;
            this.OK.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(187, 136);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(61, 42);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ChooseCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 204);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CategoryChoose);
            this.Controls.Add(this.categorySetDataGridView);
            this.Name = "ChooseCategory";
            this.Text = "Choose Category";
            this.Load += new System.EventHandler(this.CatCh_Load);
            this.VisibleChanged += new System.EventHandler(this.ChooseCategory_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource categorySetBindingSource;
        private DatabaseDataSetTableAdapters.CategorySetTableAdapter categorySetTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView categorySetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox CategoryChoose;
        private System.Windows.Forms.Button OK;
    }
}