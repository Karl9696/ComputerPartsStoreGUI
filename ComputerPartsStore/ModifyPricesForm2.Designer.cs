namespace ComputerPartsStore
{
    partial class ModifyPricesForm2
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
            this.Dashboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApplyIncreaseButton = new System.Windows.Forms.Button();
            this.DiscountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(914, 635);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(128, 61);
            this.Dashboard.TabIndex = 67;
            this.Dashboard.Text = "Back to Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 52);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(445, 48);
            this.label3.TabIndex = 66;
            this.label3.Text = "Discount Product Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Percentage for Increase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Suppliers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 345);
            this.dataGridView1.TabIndex = 63;
            // 
            // ApplyIncreaseButton
            // 
            this.ApplyIncreaseButton.Location = new System.Drawing.Point(760, 171);
            this.ApplyIncreaseButton.Name = "ApplyIncreaseButton";
            this.ApplyIncreaseButton.Size = new System.Drawing.Size(157, 58);
            this.ApplyIncreaseButton.TabIndex = 62;
            this.ApplyIncreaseButton.Text = "APPLY";
            this.ApplyIncreaseButton.UseVisualStyleBackColor = true;
            this.ApplyIncreaseButton.Click += new System.EventHandler(this.ApplyIncreaseButton_Click);
            // 
            // DiscountPercentageTextBox
            // 
            this.DiscountPercentageTextBox.Location = new System.Drawing.Point(578, 192);
            this.DiscountPercentageTextBox.Name = "DiscountPercentageTextBox";
            this.DiscountPercentageTextBox.Size = new System.Drawing.Size(159, 22);
            this.DiscountPercentageTextBox.TabIndex = 61;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(187, 189);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(180, 24);
            this.SupplierComboBox.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Product ID";
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(399, 191);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(159, 22);
            this.ProductIdTextBox.TabIndex = 68;
            // 
            // ModifyPricesForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 706);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ApplyIncreaseButton);
            this.Controls.Add(this.DiscountPercentageTextBox);
            this.Controls.Add(this.SupplierComboBox);
            this.Name = "ModifyPricesForm2";
            this.Text = "ModifyPricesForm2";
            this.Load += new System.EventHandler(this.ModifyPricesForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ApplyIncreaseButton;
        private System.Windows.Forms.TextBox DiscountPercentageTextBox;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductIdTextBox;
    }
}