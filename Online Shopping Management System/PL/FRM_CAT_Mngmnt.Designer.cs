namespace Online_Shopping_Management_System.PL
{
    partial class FRM_CAT_Mngmnt
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.textBox_CatName = new System.Windows.Forms.TextBox();
            this.textBox_CatID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.sveAllCats = new System.Windows.Forms.Button();
            this.sveCatWprd = new System.Windows.Forms.Button();
            this.prnt_Curr = new System.Windows.Forms.Button();
            this.prnt_all = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_last);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_previous);
            this.groupBox1.Controls.Add(this.btn_first);
            this.groupBox1.Controls.Add(this.textBox_CatName);
            this.groupBox1.Controls.Add(this.textBox_CatID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(259, 160);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(55, 23);
            this.btn_last.TabIndex = 7;
            this.btn_last.Text = ">>|";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(200, 160);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(53, 23);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(82, 160);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(52, 23);
            this.btn_previous.TabIndex = 5;
            this.btn_previous.Text = "<<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(22, 160);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(54, 23);
            this.btn_first.TabIndex = 4;
            this.btn_first.Text = "|<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // textBox_CatName
            // 
            this.textBox_CatName.Location = new System.Drawing.Point(97, 96);
            this.textBox_CatName.Name = "textBox_CatName";
            this.textBox_CatName.Size = new System.Drawing.Size(157, 20);
            this.textBox_CatName.TabIndex = 3;
            // 
            // textBox_CatID
            // 
            this.textBox_CatID.Location = new System.Drawing.Point(97, 39);
            this.textBox_CatID.Name = "textBox_CatID";
            this.textBox_CatID.ReadOnly = true;
            this.textBox_CatID.Size = new System.Drawing.Size(157, 20);
            this.textBox_CatID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.sveAllCats);
            this.groupBox2.Controls.Add(this.sveCatWprd);
            this.groupBox2.Controls.Add(this.prnt_Curr);
            this.groupBox2.Controls.Add(this.prnt_all);
            this.groupBox2.Controls.Add(this.exit);
            this.groupBox2.Controls.Add(this.edit);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availble Actions ";
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(141, 25);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // sveAllCats
            // 
            this.sveAllCats.Location = new System.Drawing.Point(442, 77);
            this.sveAllCats.Name = "sveAllCats";
            this.sveAllCats.Size = new System.Drawing.Size(156, 35);
            this.sveAllCats.TabIndex = 7;
            this.sveAllCats.Text = "Save Categories List As pdf";
            this.sveAllCats.UseVisualStyleBackColor = true;
            this.sveAllCats.Click += new System.EventHandler(this.sveAllCats_Click);
            // 
            // sveCatWprd
            // 
            this.sveCatWprd.Location = new System.Drawing.Point(44, 67);
            this.sveCatWprd.Name = "sveCatWprd";
            this.sveCatWprd.Size = new System.Drawing.Size(156, 35);
            this.sveCatWprd.TabIndex = 6;
            this.sveCatWprd.Text = "Save Current Category With It\'s Products As pdf";
            this.sveCatWprd.UseVisualStyleBackColor = true;
            this.sveCatWprd.Click += new System.EventHandler(this.sveCatWprd_Click);
            // 
            // prnt_Curr
            // 
            this.prnt_Curr.Location = new System.Drawing.Point(442, 20);
            this.prnt_Curr.Name = "prnt_Curr";
            this.prnt_Curr.Size = new System.Drawing.Size(122, 23);
            this.prnt_Curr.TabIndex = 5;
            this.prnt_Curr.Text = "Print Current Category";
            this.prnt_Curr.UseVisualStyleBackColor = true;
            this.prnt_Curr.Click += new System.EventHandler(this.prnt_Curr_Click);
            // 
            // prnt_all
            // 
            this.prnt_all.Location = new System.Drawing.Point(328, 25);
            this.prnt_all.Name = "prnt_all";
            this.prnt_all.Size = new System.Drawing.Size(108, 23);
            this.prnt_all.TabIndex = 4;
            this.prnt_all.Text = "Print All Categories";
            this.prnt_all.UseVisualStyleBackColor = true;
            this.prnt_all.Click += new System.EventHandler(this.prnt_all_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(570, 20);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(247, 34);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(259, 83);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Category";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(338, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 195);
            this.groupBox3.TabIndex = 2;
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
            this.dataGridView1.Size = new System.Drawing.Size(347, 173);
            this.dataGridView1.TabIndex = 3;
            // 
            // FRM_CAT_Mngmnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CAT_Mngmnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_CAT_Mngmnt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.TextBox textBox_CatName;
        private System.Windows.Forms.TextBox textBox_CatID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sveCatWprd;
        private System.Windows.Forms.Button prnt_Curr;
        private System.Windows.Forms.Button prnt_all;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button sveAllCats;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
    }
}