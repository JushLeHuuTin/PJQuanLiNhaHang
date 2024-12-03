namespace Ễ
{
    partial class C1_Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBlack = new System.Windows.Forms.RadioButton();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGachChan = new System.Windows.Forms.CheckBox();
            this.cbNghien = new System.Windows.Forms.CheckBox();
            this.cbDam = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBlack);
            this.groupBox1.Controls.Add(this.rdBlue);
            this.groupBox1.Controls.Add(this.rdGreen);
            this.groupBox1.Controls.Add(this.rdRed);
            this.groupBox1.Location = new System.Drawing.Point(52, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(272, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // rdBlack
            // 
            this.rdBlack.AutoSize = true;
            this.rdBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBlack.Location = new System.Drawing.Point(68, 188);
            this.rdBlack.Margin = new System.Windows.Forms.Padding(4);
            this.rdBlack.Name = "rdBlack";
            this.rdBlack.Size = new System.Drawing.Size(59, 20);
            this.rdBlack.TabIndex = 6;
            this.rdBlack.Text = "Black";
            this.rdBlack.UseVisualStyleBackColor = true;
            this.rdBlack.CheckedChanged += new System.EventHandler(this.rdBlack_CheckedChanged);
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdBlue.Location = new System.Drawing.Point(68, 143);
            this.rdBlue.Margin = new System.Windows.Forms.Padding(4);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(52, 20);
            this.rdBlue.TabIndex = 5;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            this.rdBlue.CheckedChanged += new System.EventHandler(this.rdBlue_CheckedChanged);
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdGreen.Location = new System.Drawing.Point(68, 92);
            this.rdGreen.Margin = new System.Windows.Forms.Padding(4);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(62, 20);
            this.rdGreen.TabIndex = 4;
            this.rdGreen.Text = "Green";
            this.rdGreen.UseVisualStyleBackColor = true;
            this.rdGreen.CheckedChanged += new System.EventHandler(this.rdGreen_CheckedChanged);
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.Checked = true;
            this.rdRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRed.ForeColor = System.Drawing.Color.Red;
            this.rdRed.Location = new System.Drawing.Point(68, 47);
            this.rdRed.Margin = new System.Windows.Forms.Padding(4);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(51, 20);
            this.rdRed.TabIndex = 3;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Red";
            this.rdRed.UseVisualStyleBackColor = true;
            this.rdRed.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGachChan);
            this.groupBox2.Controls.Add(this.cbNghien);
            this.groupBox2.Controls.Add(this.cbDam);
            this.groupBox2.Location = new System.Drawing.Point(421, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(284, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // cbGachChan
            // 
            this.cbGachChan.AutoSize = true;
            this.cbGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGachChan.Location = new System.Drawing.Point(41, 188);
            this.cbGachChan.Margin = new System.Windows.Forms.Padding(4);
            this.cbGachChan.Name = "cbGachChan";
            this.cbGachChan.Size = new System.Drawing.Size(90, 20);
            this.cbGachChan.TabIndex = 9;
            this.cbGachChan.Text = "Gạch chân";
            this.cbGachChan.UseVisualStyleBackColor = true;
            this.cbGachChan.CheckedChanged += new System.EventHandler(this.cbGachChan_CheckedChanged);
            // 
            // cbNghien
            // 
            this.cbNghien.AutoSize = true;
            this.cbNghien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNghien.Location = new System.Drawing.Point(41, 116);
            this.cbNghien.Margin = new System.Windows.Forms.Padding(4);
            this.cbNghien.Name = "cbNghien";
            this.cbNghien.Size = new System.Drawing.Size(69, 20);
            this.cbNghien.TabIndex = 8;
            this.cbNghien.Text = "Nghiên";
            this.cbNghien.UseVisualStyleBackColor = true;
            this.cbNghien.CheckedChanged += new System.EventHandler(this.cbNghien_CheckedChanged);
            // 
            // cbDam
            // 
            this.cbDam.AutoSize = true;
            this.cbDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDam.Location = new System.Drawing.Point(41, 48);
            this.cbDam.Margin = new System.Windows.Forms.Padding(4);
            this.cbDam.Name = "cbDam";
            this.cbDam.Size = new System.Drawing.Size(57, 20);
            this.cbDam.TabIndex = 7;
            this.cbDam.Text = "Đậm";
            this.cbDam.UseVisualStyleBackColor = true;
            this.cbDam.CheckedChanged += new System.EventHandler(this.cbDam_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập trình bởi:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(590, 420);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.SystemColors.Menu;
            this.lbResult.Location = new System.Drawing.Point(206, 414);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(132, 22);
            this.lbResult.TabIndex = 1;
            // 
            // C1_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(771, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "C1_Bai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng (Format)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai3_FormClosing);
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdBlack;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.CheckBox cbGachChan;
        private System.Windows.Forms.CheckBox cbNghien;
        private System.Windows.Forms.CheckBox cbDam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbResult;
    }
}