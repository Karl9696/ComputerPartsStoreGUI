namespace ComputerPartsStore
{
    partial class Form5
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
            this.LoadData = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btndeletesupplier = new System.Windows.Forms.Button();
            this.btnupdatesupplier = new System.Windows.Forms.Button();
            this.suppliertable = new System.Windows.Forms.DataGridView();
            this.btnaddsupplier = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtcontactname = new System.Windows.Forms.TextBox();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.suppliertable)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(303, 48);
            this.label4.TabIndex = 43;
            this.label4.Text = "Suppliers Page";
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(748, 582);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(110, 81);
            this.LoadData.TabIndex = 42;
            this.LoadData.Text = "Load";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 81);
            this.button4.TabIndex = 41;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btndeletesupplier
            // 
            this.btndeletesupplier.Location = new System.Drawing.Point(481, 582);
            this.btndeletesupplier.Name = "btndeletesupplier";
            this.btndeletesupplier.Size = new System.Drawing.Size(110, 81);
            this.btndeletesupplier.TabIndex = 40;
            this.btndeletesupplier.Text = "Delete";
            this.btndeletesupplier.UseVisualStyleBackColor = true;
            this.btndeletesupplier.Click += new System.EventHandler(this.btndeletesupplier_Click);
            // 
            // btnupdatesupplier
            // 
            this.btnupdatesupplier.Location = new System.Drawing.Point(342, 582);
            this.btnupdatesupplier.Name = "btnupdatesupplier";
            this.btnupdatesupplier.Size = new System.Drawing.Size(110, 81);
            this.btnupdatesupplier.TabIndex = 39;
            this.btnupdatesupplier.Text = "Edit";
            this.btnupdatesupplier.UseVisualStyleBackColor = true;
            this.btnupdatesupplier.Click += new System.EventHandler(this.btnupdatesupplier_Click);
            // 
            // suppliertable
            // 
            this.suppliertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliertable.Location = new System.Drawing.Point(242, 235);
            this.suppliertable.Name = "suppliertable";
            this.suppliertable.RowHeadersWidth = 51;
            this.suppliertable.RowTemplate.Height = 24;
            this.suppliertable.Size = new System.Drawing.Size(592, 331);
            this.suppliertable.TabIndex = 38;
            this.suppliertable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnaddsupplier
            // 
            this.btnaddsupplier.Location = new System.Drawing.Point(204, 582);
            this.btnaddsupplier.Name = "btnaddsupplier";
            this.btnaddsupplier.Size = new System.Drawing.Size(110, 81);
            this.btnaddsupplier.TabIndex = 37;
            this.btnaddsupplier.Text = "Add";
            this.btnaddsupplier.UseVisualStyleBackColor = true;
            this.btnaddsupplier.Click += new System.EventHandler(this.btnaddsupplier_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(922, 634);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(128, 61);
            this.Dashboard.TabIndex = 52;
            this.Dashboard.Text = "Back to Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(470, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 29);
            this.button5.TabIndex = 55;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(438, 90);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(199, 22);
            this.txtsearch.TabIndex = 53;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(760, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Contact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Supplier Name";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(738, 194);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(116, 22);
            this.txtaddress.TabIndex = 60;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(606, 194);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(116, 22);
            this.txtemail.TabIndex = 59;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(472, 194);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(116, 22);
            this.txtphone.TabIndex = 58;
            // 
            // txtcontactname
            // 
            this.txtcontactname.Location = new System.Drawing.Point(342, 194);
            this.txtcontactname.Name = "txtcontactname";
            this.txtcontactname.Size = new System.Drawing.Size(116, 22);
            this.txtcontactname.TabIndex = 57;
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(211, 194);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(116, 22);
            this.txtsuppliername.TabIndex = 56;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 707);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtcontactname);
            this.Controls.Add(this.txtsuppliername);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btndeletesupplier);
            this.Controls.Add(this.btnupdatesupplier);
            this.Controls.Add(this.suppliertable);
            this.Controls.Add(this.btnaddsupplier);
            this.Name = "Form5";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliertable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btndeletesupplier;
        private System.Windows.Forms.Button btnupdatesupplier;
        private System.Windows.Forms.DataGridView suppliertable;
        private System.Windows.Forms.Button btnaddsupplier;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtcontactname;
        private System.Windows.Forms.TextBox txtsuppliername;
    }
}