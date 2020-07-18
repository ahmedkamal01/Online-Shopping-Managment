namespace Online_Shopping_Management_System.PL
{
    partial class FRM_BackUp
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
            this.btn_Brws = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Path of the Backup";
            // 
            // btn_Brws
            // 
            this.btn_Brws.Location = new System.Drawing.Point(159, 95);
            this.btn_Brws.Name = "btn_Brws";
            this.btn_Brws.Size = new System.Drawing.Size(75, 23);
            this.btn_Brws.TabIndex = 1;
            this.btn_Brws.Text = "Browse";
            this.btn_Brws.UseVisualStyleBackColor = true;
            this.btn_Brws.Click += new System.EventHandler(this.btn_Brws_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(172, 160);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "Backup";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(266, 160);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancel.TabIndex = 3;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(91, 55);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.ReadOnly = true;
            this.textBox_FName.Size = new System.Drawing.Size(250, 20);
            this.textBox_FName.TabIndex = 4;
            // 
            // FRM_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 204);
            this.Controls.Add(this.textBox_FName);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Brws);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BackUp";
            this.Text = "FRM_BackUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Brws;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}