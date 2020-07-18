namespace Online_Shopping_Management_System.PL
{
    partial class Prdct_Mngmnt
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sve_excel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Print_All = new System.Windows.Forms.Button();
            this.Print_selctd = new System.Windows.Forms.Button();
            this.Edit_Prdct = new System.Windows.Forms.Button();
            this.Show_img = new System.Windows.Forms.Button();
            this.Delete_prdct = new System.Windows.Forms.Button();
            this.Add_New_prdct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What Do you want to Search for ?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(617, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sve_excel);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Print_All);
            this.groupBox2.Controls.Add(this.Print_selctd);
            this.groupBox2.Controls.Add(this.Edit_Prdct);
            this.groupBox2.Controls.Add(this.Show_img);
            this.groupBox2.Controls.Add(this.Delete_prdct);
            this.groupBox2.Controls.Add(this.Add_New_prdct);
            this.groupBox2.Location = new System.Drawing.Point(15, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Actions";
            // 
            // sve_excel
            // 
            this.sve_excel.Location = new System.Drawing.Point(480, 30);
            this.sve_excel.Name = "sve_excel";
            this.sve_excel.Size = new System.Drawing.Size(140, 29);
            this.sve_excel.TabIndex = 7;
            this.sve_excel.Text = "Save In Excel Sheet";
            this.sve_excel.UseVisualStyleBackColor = true;
            this.sve_excel.Click += new System.EventHandler(this.sve_excel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Print_All
            // 
            this.Print_All.Location = new System.Drawing.Point(239, 89);
            this.Print_All.Name = "Print_All";
            this.Print_All.Size = new System.Drawing.Size(140, 29);
            this.Print_All.TabIndex = 5;
            this.Print_All.Text = "Print All Products";
            this.Print_All.UseVisualStyleBackColor = true;
            this.Print_All.Click += new System.EventHandler(this.Print_All_Click);
            // 
            // Print_selctd
            // 
            this.Print_selctd.Location = new System.Drawing.Point(17, 89);
            this.Print_selctd.Name = "Print_selctd";
            this.Print_selctd.Size = new System.Drawing.Size(140, 29);
            this.Print_selctd.TabIndex = 4;
            this.Print_selctd.Text = "Print Selected Product";
            this.Print_selctd.UseVisualStyleBackColor = true;
            this.Print_selctd.Click += new System.EventHandler(this.Print_selctd_Click);
            // 
            // Edit_Prdct
            // 
            this.Edit_Prdct.Location = new System.Drawing.Point(17, 31);
            this.Edit_Prdct.Name = "Edit_Prdct";
            this.Edit_Prdct.Size = new System.Drawing.Size(140, 28);
            this.Edit_Prdct.TabIndex = 3;
            this.Edit_Prdct.Text = "Edit Selected Product";
            this.Edit_Prdct.UseVisualStyleBackColor = true;
            this.Edit_Prdct.Click += new System.EventHandler(this.Edit_Prdct_Click);
            // 
            // Show_img
            // 
            this.Show_img.Location = new System.Drawing.Point(480, 89);
            this.Show_img.Name = "Show_img";
            this.Show_img.Size = new System.Drawing.Size(140, 28);
            this.Show_img.TabIndex = 2;
            this.Show_img.Text = "Show Image";
            this.Show_img.UseVisualStyleBackColor = true;
            this.Show_img.Click += new System.EventHandler(this.Show_img_Click);
            // 
            // Delete_prdct
            // 
            this.Delete_prdct.Location = new System.Drawing.Point(17, 139);
            this.Delete_prdct.Name = "Delete_prdct";
            this.Delete_prdct.Size = new System.Drawing.Size(140, 29);
            this.Delete_prdct.TabIndex = 1;
            this.Delete_prdct.Text = "Delete Selected Product";
            this.Delete_prdct.UseVisualStyleBackColor = true;
            this.Delete_prdct.Click += new System.EventHandler(this.Delete_prdct_Click);
            // 
            // Add_New_prdct
            // 
            this.Add_New_prdct.Location = new System.Drawing.Point(239, 30);
            this.Add_New_prdct.Name = "Add_New_prdct";
            this.Add_New_prdct.Size = new System.Drawing.Size(140, 29);
            this.Add_New_prdct.TabIndex = 0;
            this.Add_New_prdct.Text = "Add New Product";
            this.Add_New_prdct.UseVisualStyleBackColor = true;
            this.Add_New_prdct.Click += new System.EventHandler(this.Add_New_prdct_Click);
            this.Add_New_prdct.Leave += new System.EventHandler(this.Add_New_prdct_Leave);
            // 
            // Prdct_Mngmnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prdct_Mngmnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Mangement ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sve_excel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Print_All;
        private System.Windows.Forms.Button Print_selctd;
        private System.Windows.Forms.Button Edit_Prdct;
        private System.Windows.Forms.Button Show_img;
        private System.Windows.Forms.Button Delete_prdct;
        private System.Windows.Forms.Button Add_New_prdct;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}