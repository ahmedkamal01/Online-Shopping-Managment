namespace Online_Shopping_Management_System.PL
{
    partial class FRM_BELLS_MNGMNT
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_WORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPRNT = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_new = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 318);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categories List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 296);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox_WORD
            // 
            this.textBox_WORD.Location = new System.Drawing.Point(241, 36);
            this.textBox_WORD.Name = "textBox_WORD";
            this.textBox_WORD.Size = new System.Drawing.Size(227, 20);
            this.textBox_WORD.TabIndex = 4;
            this.textBox_WORD.TextChanged += new System.EventHandler(this.textBox_CatName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Here :";
            // 
            // btnPRNT
            // 
            this.btnPRNT.Location = new System.Drawing.Point(6, 81);
            this.btnPRNT.Name = "btnPRNT";
            this.btnPRNT.Size = new System.Drawing.Size(98, 23);
            this.btnPRNT.TabIndex = 0;
            this.btnPRNT.Text = "Print";
            this.btnPRNT.UseVisualStyleBackColor = true;
            this.btnPRNT.Click += new System.EventHandler(this.btnPRNT_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(6, 157);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(98, 23);
            this.EXIT.TabIndex = 8;
            this.EXIT.Text = "Exit";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Btn_new);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.EXIT);
            this.groupBox2.Controls.Add(this.btnPRNT);
            this.groupBox2.Location = new System.Drawing.Point(572, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 318);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availble Actions ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Turn Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_new
            // 
            this.Btn_new.Location = new System.Drawing.Point(6, 43);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.Size = new System.Drawing.Size(98, 23);
            this.Btn_new.TabIndex = 10;
            this.Btn_new.Text = "New Bell";
            this.Btn_new.UseVisualStyleBackColor = true;
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_BELLS_MNGMNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_WORD);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BELLS_MNGMNT";
            this.Text = "FRM_BELLS_MNGMNT";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_WORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPRNT;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_new;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}