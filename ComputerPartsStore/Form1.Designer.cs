﻿namespace ComputerPartsStore
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductCategories = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Computer Parts Store";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ProductCategories
            // 
            this.ProductCategories.Location = new System.Drawing.Point(398, 201);
            this.ProductCategories.Name = "ProductCategories";
            this.ProductCategories.Size = new System.Drawing.Size(184, 91);
            this.ProductCategories.TabIndex = 1;
            this.ProductCategories.Text = "Product Categories";
            this.ProductCategories.UseVisualStyleBackColor = true;
            this.ProductCategories.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit App";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 91);
            this.button4.TabIndex = 4;
            this.button4.Text = "View Customers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(398, 420);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 91);
            this.button6.TabIndex = 5;
            this.button6.Text = "View Suppliers";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(398, 538);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 91);
            this.button5.TabIndex = 6;
            this.button5.Text = "View Orders";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 753);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductCategories);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Navigation Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductCategories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

