
namespace ComplainAnalysis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataCountTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.thresholdRatioTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valueFieldCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compareFieldCmb = new System.Windows.Forms.ComboBox();
            this.compareFieldLbl = new System.Windows.Forms.Label();
            this.sameProductsCb = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.complaintId = new System.Windows.Forms.Label();
            this.threadPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.threadListGV = new System.Windows.Forms.DataGridView();
            this.matchPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.matchListGV = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.threadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadListGV)).BeginInit();
            this.matchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchListGV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thred Sayısı";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataCountTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.thresholdRatioTxt);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.valueFieldCmb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.compareFieldCmb);
            this.panel2.Controls.Add(this.compareFieldLbl);
            this.panel2.Controls.Add(this.sameProductsCb);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.complaintId);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 475);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataCountTxt
            // 
            this.dataCountTxt.Location = new System.Drawing.Point(19, 374);
            this.dataCountTxt.Name = "dataCountTxt";
            this.dataCountTxt.Size = new System.Drawing.Size(211, 27);
            this.dataCountTxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Veri Sayısı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(19, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seçenekler";
            // 
            // thresholdRatioTxt
            // 
            this.thresholdRatioTxt.Location = new System.Drawing.Point(19, 266);
            this.thresholdRatioTxt.Name = "thresholdRatioTxt";
            this.thresholdRatioTxt.Size = new System.Drawing.Size(211, 27);
            this.thresholdRatioTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Benzerlik Oranı";
            // 
            // valueFieldCmb
            // 
            this.valueFieldCmb.FormattingEnabled = true;
            this.valueFieldCmb.Location = new System.Drawing.Point(19, 209);
            this.valueFieldCmb.Name = "valueFieldCmb";
            this.valueFieldCmb.Size = new System.Drawing.Size(211, 28);
            this.valueFieldCmb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gösterilecek Alan";
            // 
            // compareFieldCmb
            // 
            this.compareFieldCmb.FormattingEnabled = true;
            this.compareFieldCmb.Location = new System.Drawing.Point(19, 152);
            this.compareFieldCmb.Name = "compareFieldCmb";
            this.compareFieldCmb.Size = new System.Drawing.Size(211, 28);
            this.compareFieldCmb.TabIndex = 9;
            // 
            // compareFieldLbl
            // 
            this.compareFieldLbl.AutoSize = true;
            this.compareFieldLbl.Location = new System.Drawing.Point(19, 129);
            this.compareFieldLbl.Name = "compareFieldLbl";
            this.compareFieldLbl.Size = new System.Drawing.Size(145, 20);
            this.compareFieldLbl.TabIndex = 8;
            this.compareFieldLbl.Text = "Karşılaştırılacak Alan";
            // 
            // sameProductsCb
            // 
            this.sameProductsCb.AutoSize = true;
            this.sameProductsCb.Location = new System.Drawing.Point(22, 95);
            this.sameProductsCb.Name = "sameProductsCb";
            this.sameProductsCb.Size = new System.Drawing.Size(139, 24);
            this.sameProductsCb.TabIndex = 7;
            this.sameProductsCb.Text = "Aynı Ürünler İçin";
            this.sameProductsCb.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 27);
            this.textBox2.TabIndex = 6;
            // 
            // complaintId
            // 
            this.complaintId.AutoSize = true;
            this.complaintId.Location = new System.Drawing.Point(19, 33);
            this.complaintId.Name = "complaintId";
            this.complaintId.Size = new System.Drawing.Size(95, 20);
            this.complaintId.TabIndex = 5;
            this.complaintId.Text = "Complaint Id";
            // 
            // threadPanel
            // 
            this.threadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threadPanel.Controls.Add(this.label5);
            this.threadPanel.Controls.Add(this.threadListGV);
            this.threadPanel.Location = new System.Drawing.Point(269, 12);
            this.threadPanel.Name = "threadPanel";
            this.threadPanel.Size = new System.Drawing.Size(274, 475);
            this.threadPanel.TabIndex = 6;
            this.threadPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Threadler";
            // 
            // threadListGV
            // 
            this.threadListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.threadListGV.Location = new System.Drawing.Point(3, 40);
            this.threadListGV.Name = "threadListGV";
            this.threadListGV.RowHeadersWidth = 51;
            this.threadListGV.RowTemplate.Height = 29;
            this.threadListGV.Size = new System.Drawing.Size(266, 417);
            this.threadListGV.TabIndex = 0;
            // 
            // matchPanel
            // 
            this.matchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchPanel.Controls.Add(this.label6);
            this.matchPanel.Controls.Add(this.matchListGV);
            this.matchPanel.Location = new System.Drawing.Point(549, 12);
            this.matchPanel.Name = "matchPanel";
            this.matchPanel.Size = new System.Drawing.Size(674, 475);
            this.matchPanel.TabIndex = 7;
            this.matchPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Eşleşmeler";
            // 
            // matchListGV
            // 
            this.matchListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchListGV.Location = new System.Drawing.Point(3, 40);
            this.matchListGV.Name = "matchListGV";
            this.matchListGV.RowHeadersWidth = 51;
            this.matchListGV.RowTemplate.Height = 29;
            this.matchListGV.Size = new System.Drawing.Size(666, 416);
            this.matchListGV.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 499);
            this.Controls.Add(this.matchPanel);
            this.Controls.Add(this.threadPanel);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.threadPanel.ResumeLayout(false);
            this.threadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadListGV)).EndInit();
            this.matchPanel.ResumeLayout(false);
            this.matchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchListGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thresholdRatioTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox valueFieldCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox compareFieldCmb;
        private System.Windows.Forms.Label compareFieldLbl;
        private System.Windows.Forms.CheckBox sameProductsCb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label complaintId;
        private System.Windows.Forms.Panel threadPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView threadListGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel matchPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView matchListGV;
        private System.Windows.Forms.TextBox dataCountTxt;
        private System.Windows.Forms.Label label7;
    }
}

