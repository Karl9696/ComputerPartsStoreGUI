namespace ComputerPartsStore
{
    partial class CustomerOrdersForm
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
            this.CustomerOrdersTable = new System.Windows.Forms.DataGridView();
            this.Dashboard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrdersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 19);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(340, 48);
            this.label4.TabIndex = 51;
            this.label4.Text = "Customer Orders";
            // 
            // CustomerOrdersTable
            // 
            this.CustomerOrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerOrdersTable.Location = new System.Drawing.Point(234, 135);
            this.CustomerOrdersTable.Name = "CustomerOrdersTable";
            this.CustomerOrdersTable.RowHeadersWidth = 51;
            this.CustomerOrdersTable.RowTemplate.Height = 24;
            this.CustomerOrdersTable.Size = new System.Drawing.Size(592, 331);
            this.CustomerOrdersTable.TabIndex = 52;
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(868, 621);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(128, 61);
            this.Dashboard.TabIndex = 53;
            this.Dashboard.Text = "Back to Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 61);
            this.button1.TabIndex = 54;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.CustomerOrdersTable);
            this.Controls.Add(this.label4);
            this.Name = "CustomerOrdersForm";
            this.Text = "CustomerOrdersForm";
            this.Load += new System.EventHandler(this.CustomerOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrdersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CustomerOrdersTable;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button button1;
    }
}