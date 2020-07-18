namespace Online_Shopping_Management_System.PL
{
    partial class FRM_ADD_PRODUCT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_PRD_Price = new System.Windows.Forms.TextBox();
            this.ChooseImg = new System.Windows.Forms.Button();
            this.pictureBox_PRD_Img = new System.Windows.Forms.PictureBox();
            this.textBox_PRD_Qunt = new System.Windows.Forms.TextBox();
            this.textBox_PRD_Name = new System.Windows.Forms.TextBox();
            this.textBox_PRD_ID = new System.Windows.Forms.TextBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PRD_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_PRD_Price);
            this.groupBox1.Controls.Add(this.ChooseImg);
            this.groupBox1.Controls.Add(this.pictureBox_PRD_Img);
            this.groupBox1.Controls.Add(this.textBox_PRD_Qunt);
            this.groupBox1.Controls.Add(this.textBox_PRD_Name);
            this.groupBox1.Controls.Add(this.textBox_PRD_ID);
            this.groupBox1.Controls.Add(this.comboBox_Categories);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.AddProduct);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price :";
            // 
            // textBox_PRD_Price
            // 
            this.textBox_PRD_Price.Location = new System.Drawing.Point(153, 164);
            this.textBox_PRD_Price.Name = "textBox_PRD_Price";
            this.textBox_PRD_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_PRD_Price.TabIndex = 13;
            // 
            // ChooseImg
            // 
            this.ChooseImg.Location = new System.Drawing.Point(378, 267);
            this.ChooseImg.Name = "ChooseImg";
            this.ChooseImg.Size = new System.Drawing.Size(92, 23);
            this.ChooseImg.TabIndex = 12;
            this.ChooseImg.Text = "Choose Image";
            this.ChooseImg.UseVisualStyleBackColor = true;
            this.ChooseImg.Click += new System.EventHandler(this.ChooseImg_Click);
            // 
            // pictureBox_PRD_Img
            // 
            this.pictureBox_PRD_Img.Location = new System.Drawing.Point(153, 193);
            this.pictureBox_PRD_Img.Name = "pictureBox_PRD_Img";
            this.pictureBox_PRD_Img.Size = new System.Drawing.Size(203, 153);
            this.pictureBox_PRD_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PRD_Img.TabIndex = 11;
            this.pictureBox_PRD_Img.TabStop = false;
            // 
            // textBox_PRD_Qunt
            // 
            this.textBox_PRD_Qunt.Location = new System.Drawing.Point(153, 134);
            this.textBox_PRD_Qunt.Name = "textBox_PRD_Qunt";
            this.textBox_PRD_Qunt.Size = new System.Drawing.Size(100, 20);
            this.textBox_PRD_Qunt.TabIndex = 10;
            // 
            // textBox_PRD_Name
            // 
            this.textBox_PRD_Name.Location = new System.Drawing.Point(153, 104);
            this.textBox_PRD_Name.Name = "textBox_PRD_Name";
            this.textBox_PRD_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_PRD_Name.TabIndex = 9;
            // 
            // textBox_PRD_ID
            // 
            this.textBox_PRD_ID.Location = new System.Drawing.Point(153, 74);
            this.textBox_PRD_ID.Name = "textBox_PRD_ID";
            this.textBox_PRD_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_PRD_ID.TabIndex = 8;
            this.textBox_PRD_ID.Validated += new System.EventHandler(this.textBox_PRD_ID_Validated);
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(132, 43);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Categories.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Product_Image :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product_Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product_ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category :";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(347, 390);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(92, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(178, 390);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(92, 23);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 469);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_ADD_PRODUCT";
            this.Text = "Add_New_Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PRD_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_PRD_Price;
        public System.Windows.Forms.Button ChooseImg;
        public System.Windows.Forms.PictureBox pictureBox_PRD_Img;
        public System.Windows.Forms.TextBox textBox_PRD_Qunt;
        public System.Windows.Forms.TextBox textBox_PRD_Name;
        public System.Windows.Forms.TextBox textBox_PRD_ID;
        public System.Windows.Forms.ComboBox comboBox_Categories;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Button AddProduct;
    }
}