namespace Project
{
    partial class Form3
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
            this.btnHsp = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFileProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHsp
            // 
            this.btnHsp.BackColor = System.Drawing.SystemColors.Info;
            this.btnHsp.Location = new System.Drawing.Point(308, 182);
            this.btnHsp.Name = "btnHsp";
            this.btnHsp.Size = new System.Drawing.Size(75, 89);
            this.btnHsp.TabIndex = 5;
            this.btnHsp.Text = "Calculator";
            this.btnHsp.UseVisualStyleBackColor = false;
            this.btnHsp.Click += new System.EventHandler(this.btnHsp_Click_1);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.Info;
            this.btnFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFile.Location = new System.Drawing.Point(113, 182);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 89);
            this.btnFile.TabIndex = 6;
            this.btnFile.Text = "File Setting ";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(122, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome my first windows form application";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(141, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select the action you want to perform";
            // 
            // btnFileProcess
            // 
            this.btnFileProcess.BackColor = System.Drawing.SystemColors.Info;
            this.btnFileProcess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFileProcess.Location = new System.Drawing.Point(222, 310);
            this.btnFileProcess.Name = "btnFileProcess";
            this.btnFileProcess.Size = new System.Drawing.Size(75, 89);
            this.btnFileProcess.TabIndex = 9;
            this.btnFileProcess.Text = "File Process";
            this.btnFileProcess.UseVisualStyleBackColor = false;
            this.btnFileProcess.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.btnFileProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnHsp);
            this.Name = "Form3";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHsp;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFileProcess;
    }
}