namespace ComputerPartsStore
{
    partial class ModifyPricesForm
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
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.PercentageIncreaseTextBox = new System.Windows.Forms.TextBox();
            this.ApplyIncreaseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(291, 198);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(180, 24);
            this.SupplierComboBox.TabIndex = 0;
            // 
            // PercentageIncreaseTextBox
            // 
            this.PercentageIncreaseTextBox.Location = new System.Drawing.Point(487, 200);
            this.PercentageIncreaseTextBox.Name = "PercentageIncreaseTextBox";
            this.PercentageIncreaseTextBox.Size = new System.Drawing.Size(159, 22);
            this.PercentageIncreaseTextBox.TabIndex = 1;
            // 
            // ApplyIncreaseButton
            // 
            this.ApplyIncreaseButton.Location = new System.Drawing.Point(669, 179);
            this.ApplyIncreaseButton.Name = "ApplyIncreaseButton";
            this.ApplyIncreaseButton.Size = new System.Drawing.Size(157, 58);
            this.ApplyIncreaseButton.TabIndex = 2;
            this.ApplyIncreaseButton.Text = "APPLY";
            this.ApplyIncreaseButton.UseVisualStyleBackColor = true;
            this.ApplyIncreaseButton.Click += new System.EventHandler(this.ApplyIncreaseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suppliers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Percentage for Increase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 50);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(473, 48);
            this.label3.TabIndex = 57;
            this.label3.Text = "Increase Supplier Prices";
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(920, 633);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(128, 61);
            this.Dashboard.TabIndex = 59;
            this.Dashboard.Text = "Back to Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // ModifyPricesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 706);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ApplyIncreaseButton);
            this.Controls.Add(this.PercentageIncreaseTextBox);
            this.Controls.Add(this.SupplierComboBox);
            this.Name = "ModifyPricesForm";
            this.Text = "ModifyPricesForm";
            this.Load += new System.EventHandler(this.ModifyPricesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.TextBox PercentageIncreaseTextBox;
        private System.Windows.Forms.Button ApplyIncreaseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dashboard;
    }
}