namespace Online_Shopping_Management_System.PL
{
    partial class FRM_Settings
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
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.textBox_database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RDBTN_Windows = new System.Windows.Forms.RadioButton();
            this.RDBTN_SQL = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.btn_SVE = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // textBox_server
            // 
            this.textBox_server.Location = new System.Drawing.Point(134, 33);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(179, 20);
            this.textBox_server.TabIndex = 1;
            // 
            // textBox_database
            // 
            this.textBox_database.Location = new System.Drawing.Point(134, 69);
            this.textBox_database.Name = "textBox_database";
            this.textBox_database.Size = new System.Drawing.Size(179, 20);
            this.textBox_database.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database :";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(134, 161);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.ReadOnly = true;
            this.textBox_UserName.Size = new System.Drawing.Size(179, 20);
            this.textBox_UserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Authentication Mode :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name :";
            // 
            // RDBTN_Windows
            // 
            this.RDBTN_Windows.AutoSize = true;
            this.RDBTN_Windows.Location = new System.Drawing.Point(134, 106);
            this.RDBTN_Windows.Name = "RDBTN_Windows";
            this.RDBTN_Windows.Size = new System.Drawing.Size(140, 17);
            this.RDBTN_Windows.TabIndex = 7;
            this.RDBTN_Windows.TabStop = true;
            this.RDBTN_Windows.Text = "Windows Authentication";
            this.RDBTN_Windows.UseVisualStyleBackColor = true;
            this.RDBTN_Windows.CheckedChanged += new System.EventHandler(this.RDBTN_Windows_CheckedChanged);
            // 
            // RDBTN_SQL
            // 
            this.RDBTN_SQL.AutoSize = true;
            this.RDBTN_SQL.Location = new System.Drawing.Point(134, 129);
            this.RDBTN_SQL.Name = "RDBTN_SQL";
            this.RDBTN_SQL.Size = new System.Drawing.Size(151, 17);
            this.RDBTN_SQL.TabIndex = 8;
            this.RDBTN_SQL.TabStop = true;
            this.RDBTN_SQL.Text = "SQL Server Authentication";
            this.RDBTN_SQL.UseVisualStyleBackColor = true;
            this.RDBTN_SQL.CheckedChanged += new System.EventHandler(this.RDBTN_SQL_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(134, 195);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.ReadOnly = true;
            this.textBox_Pass.Size = new System.Drawing.Size(179, 20);
            this.textBox_Pass.TabIndex = 9;
            // 
            // btn_SVE
            // 
            this.btn_SVE.Location = new System.Drawing.Point(45, 255);
            this.btn_SVE.Name = "btn_SVE";
            this.btn_SVE.Size = new System.Drawing.Size(104, 23);
            this.btn_SVE.TabIndex = 11;
            this.btn_SVE.Text = "Save Settings";
            this.btn_SVE.UseVisualStyleBackColor = true;
            this.btn_SVE.Click += new System.EventHandler(this.btn_SVE_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(193, 255);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FRM_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 308);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_SVE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.RDBTN_SQL);
            this.Controls.Add(this.RDBTN_Windows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_database);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_server);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Settings";
            this.Text = "FRM_Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.TextBox textBox_database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RDBTN_Windows;
        private System.Windows.Forms.RadioButton RDBTN_SQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button btn_SVE;
        private System.Windows.Forms.Button btn_Exit;
    }
}