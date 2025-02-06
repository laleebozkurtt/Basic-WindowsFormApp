namespace Project
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_mlt = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.maskedtxtiki = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtilk = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sum.Location = new System.Drawing.Point(275, 40);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 27);
            this.btn_sum.TabIndex = 9;
            this.btn_sum.Text = "Topla";
            this.btn_sum.UseVisualStyleBackColor = false;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_mlt
            // 
            this.btn_mlt.BackColor = System.Drawing.SystemColors.Info;
            this.btn_mlt.Location = new System.Drawing.Point(275, 199);
            this.btn_mlt.Name = "btn_mlt";
            this.btn_mlt.Size = new System.Drawing.Size(75, 25);
            this.btn_mlt.TabIndex = 10;
            this.btn_mlt.Text = "*";
            this.btn_mlt.UseVisualStyleBackColor = false;
            this.btn_mlt.Click += new System.EventHandler(this.btn_mlt_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.SystemColors.Info;
            this.btn_div.Location = new System.Drawing.Point(275, 150);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 24);
            this.btn_div.TabIndex = 11;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sub.Location = new System.Drawing.Point(275, 93);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 26);
            this.btn_sub.TabIndex = 12;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Info;
            this.btn_clear.Location = new System.Drawing.Point(152, 192);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 38);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome to calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtsonuc
            // 
            this.txtsonuc.BackColor = System.Drawing.SystemColors.Info;
            this.txtsonuc.Location = new System.Drawing.Point(140, 126);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.ReadOnly = true;
            this.txtsonuc.Size = new System.Drawing.Size(100, 22);
            this.txtsonuc.TabIndex = 23;
            this.txtsonuc.TextChanged += new System.EventHandler(this.lblSonuc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ilk sayı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ikıncı sayı :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sonuc :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedtxtilk);
            this.groupBox1.Controls.Add(this.maskedtxtiki);
            this.groupBox1.Controls.Add(this.btn_div);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_sum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_mlt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_sub);
            this.groupBox1.Controls.Add(this.txtsonuc);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Location = new System.Drawing.Point(29, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 255);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(443, 26);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(7, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(26, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Back";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // maskedtxtiki
            // 
            this.maskedtxtiki.BackColor = System.Drawing.SystemColors.Info;
            this.maskedtxtiki.Location = new System.Drawing.Point(140, 68);
            this.maskedtxtiki.Mask = "00000";
            this.maskedtxtiki.Name = "maskedtxtiki";
            this.maskedtxtiki.Size = new System.Drawing.Size(100, 22);
            this.maskedtxtiki.TabIndex = 24;
            this.maskedtxtiki.ValidatingType = typeof(int);
            this.maskedtxtiki.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedtxtiki_MaskInputRejected);
            // 
            // maskedtxtilk
            // 
            this.maskedtxtilk.BackColor = System.Drawing.SystemColors.Info;
            this.maskedtxtilk.Location = new System.Drawing.Point(140, 37);
            this.maskedtxtilk.Mask = "00000";
            this.maskedtxtilk.Name = "maskedtxtilk";
            this.maskedtxtilk.Size = new System.Drawing.Size(100, 22);
            this.maskedtxtilk.TabIndex = 25;
            this.maskedtxtilk.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedtxtilk_MaskInputRejected);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 388);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Calculator : ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_mlt;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox maskedtxtilk;
        private System.Windows.Forms.MaskedTextBox maskedtxtiki;
    }
}