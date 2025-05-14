namespace ComputerPartsStore
{
    partial class SupplierProductsForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.SupplierProductTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierProductTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, -106);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(340, 48);
            this.label4.TabIndex = 55;
            this.label4.Text = "Customer Orders";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 61);
            this.button1.TabIndex = 59;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(869, 621);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(128, 61);
            this.Dashboard.TabIndex = 58;
            this.Dashboard.Text = "Back to Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // SupplierProductTable
            // 
            this.SupplierProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierProductTable.Location = new System.Drawing.Point(235, 135);
            this.SupplierProductTable.Name = "SupplierProductTable";
            this.SupplierProductTable.RowHeadersWidth = 51;
            this.SupplierProductTable.RowTemplate.Height = 24;
            this.SupplierProductTable.Size = new System.Drawing.Size(592, 331);
            this.SupplierProductTable.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(350, 48);
            this.label1.TabIndex = 56;
            this.label1.Text = "Supplier Products";
            // 
            // SupplierProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.SupplierProductTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "SupplierProductsForm";
            this.Text = "SupplierProductsForm";
            this.Load += new System.EventHandler(this.SupplierProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierProductTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.DataGridView SupplierProductTable;
        private System.Windows.Forms.Label label1;
    }
}