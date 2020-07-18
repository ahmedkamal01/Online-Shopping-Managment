namespace Online_Shopping_Management_System.PL
{
    partial class FRM_Restore
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
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.btn_rest = new System.Windows.Forms.Button();
            this.btn_Brws = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(91, 70);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.ReadOnly = true;
            this.textBox_FName.Size = new System.Drawing.Size(250, 20);
            this.textBox_FName.TabIndex = 9;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(266, 175);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancel.TabIndex = 8;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_rest
            // 
            this.btn_rest.Location = new System.Drawing.Point(172, 175);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(75, 23);
            this.btn_rest.TabIndex = 7;
            this.btn_rest.Text = "Restore";
            this.btn_rest.UseVisualStyleBackColor = true;
            this.btn_rest.Click += new System.EventHandler(this.btn_rest_Click);
            // 
            // btn_Brws
            // 
            this.btn_Brws.Location = new System.Drawing.Point(159, 110);
            this.btn_Brws.Name = "btn_Brws";
            this.btn_Brws.Size = new System.Drawing.Size(75, 23);
            this.btn_Brws.TabIndex = 6;
            this.btn_Brws.Text = "Browse";
            this.btn_Brws.UseVisualStyleBackColor = true;
            this.btn_Brws.Click += new System.EventHandler(this.btn_Brws_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Path of the Backup";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Backup Files |*.*\"";
            // 
            // FRM_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 383);
            this.Controls.Add(this.textBox_FName);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.btn_rest);
            this.Controls.Add(this.btn_Brws);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Restore";
            this.Text = "Restore Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button btn_rest;
        private System.Windows.Forms.Button btn_Brws;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}