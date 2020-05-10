namespace Aplikacja
{
    partial class Form1
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
            this.SrcPath = new System.Windows.Forms.TextBox();
            this.repPath = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.TbSurname = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SrcPattern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.maskedTBDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DealNoTb = new System.Windows.Forms.TextBox();
            this.DealNoLbl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Raport źródłowy:";
            // 
            // SrcPath
            // 
            this.SrcPath.Location = new System.Drawing.Point(146, 15);
            this.SrcPath.Name = "SrcPath";
            this.SrcPath.Size = new System.Drawing.Size(510, 26);
            this.SrcPath.TabIndex = 1;
            // 
            // repPath
            // 
            this.repPath.FileName = "repPath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwisko:";
            // 
            // TbSurname
            // 
            this.TbSurname.Location = new System.Drawing.Point(146, 117);
            this.TbSurname.Name = "TbSurname";
            this.TbSurname.Size = new System.Drawing.Size(242, 26);
            this.TbSurname.TabIndex = 4;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(146, 163);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(242, 26);
            this.TbName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Imię:";
            // 
            // SrcPattern
            // 
            this.SrcPattern.Location = new System.Drawing.Point(146, 63);
            this.SrcPattern.Name = "SrcPattern";
            this.SrcPattern.Size = new System.Drawing.Size(510, 26);
            this.SrcPattern.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cennik:";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(406, 156);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(250, 72);
            this.BtnConfirm.TabIndex = 7;
            this.BtnConfirm.Text = "Stwórz podsumowanie";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // maskedTBDate
            // 
            this.maskedTBDate.Location = new System.Drawing.Point(146, 202);
            this.maskedTBDate.Mask = "00-00-0000";
            this.maskedTBDate.Name = "maskedTBDate";
            this.maskedTBDate.Size = new System.Drawing.Size(242, 26);
            this.maskedTBDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data:";
            // 
            // DealNoTb
            // 
            this.DealNoTb.Location = new System.Drawing.Point(483, 117);
            this.DealNoTb.Name = "DealNoTb";
            this.DealNoTb.Size = new System.Drawing.Size(172, 26);
            this.DealNoTb.TabIndex = 3;
            // 
            // DealNoLbl
            // 
            this.DealNoLbl.AutoSize = true;
            this.DealNoLbl.Location = new System.Drawing.Point(406, 120);
            this.DealNoLbl.Name = "DealNoLbl";
            this.DealNoLbl.Size = new System.Drawing.Size(71, 20);
            this.DealNoLbl.TabIndex = 11;
            this.DealNoLbl.Text = "Umowa: ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 241);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(191, 17);
            this.toolStripStatusLabel1.Text = "©COPYRIGHT SZYMON KAMIŃSKI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(662, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 213);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ważne informacje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "DATA w formacie dd.mm.rrrr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cennik -> Plik xlsx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Raport źródłowy -> Plik xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DealNoLbl);
            this.Controls.Add(this.DealNoTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTBDate);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.SrcPattern);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SrcPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SrcPath;
        private System.Windows.Forms.OpenFileDialog repPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbSurname;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SrcPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.MaskedTextBox maskedTBDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DealNoTb;
        private System.Windows.Forms.Label DealNoLbl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

