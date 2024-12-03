namespace Ễ
{
    partial class C1_Bai7
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
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.btnTongUocSo = new System.Windows.Forms.Button();
            this.btnTongSoChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocSo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNumber);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Location = new System.Drawing.Point(86, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Location = new System.Drawing.Point(23, 80);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(208, 21);
            this.cbNumber.TabIndex = 2;
            this.cbNumber.SelectedIndexChanged += new System.EventHandler(this.cbNumber_SelectedIndexChanged);
            this.cbNumber.Click += new System.EventHandler(this.cbNumber_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(23, 36);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(121, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbMain);
            this.groupBox2.Location = new System.Drawing.Point(470, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 211);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(38, 33);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(205, 160);
            this.lbMain.TabIndex = 2;
            // 
            // btnTongUocSo
            // 
            this.btnTongUocSo.Location = new System.Drawing.Point(494, 266);
            this.btnTongUocSo.Name = "btnTongUocSo";
            this.btnTongUocSo.Size = new System.Drawing.Size(219, 30);
            this.btnTongUocSo.TabIndex = 3;
            this.btnTongUocSo.Text = "Tổng các ước số";
            this.btnTongUocSo.UseVisualStyleBackColor = true;
            this.btnTongUocSo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTongSoChan
            // 
            this.btnTongSoChan.Location = new System.Drawing.Point(494, 315);
            this.btnTongSoChan.Name = "btnTongSoChan";
            this.btnTongSoChan.Size = new System.Drawing.Size(219, 30);
            this.btnTongSoChan.TabIndex = 4;
            this.btnTongSoChan.Text = "Số lượng các ước số chẵn";
            this.btnTongSoChan.UseVisualStyleBackColor = true;
            this.btnTongSoChan.Click += new System.EventHandler(this.btnTongSoChan_Click);
            // 
            // btnSoLuongUocSo
            // 
            this.btnSoLuongUocSo.Location = new System.Drawing.Point(494, 365);
            this.btnSoLuongUocSo.Name = "btnSoLuongUocSo";
            this.btnSoLuongUocSo.Size = new System.Drawing.Size(219, 30);
            this.btnSoLuongUocSo.TabIndex = 5;
            this.btnSoLuongUocSo.Text = "Số lượng các ước số nguyên tố";
            this.btnSoLuongUocSo.UseVisualStyleBackColor = true;
            this.btnSoLuongUocSo.Click += new System.EventHandler(this.btnSoLuongUocSo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 335);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // C1_Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSoLuongUocSo);
            this.Controls.Add(this.btnTongSoChan);
            this.Controls.Add(this.btnTongUocSo);
            this.Controls.Add(this.groupBox1);
            this.Name = "C1_Bai7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai7_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTongUocSo;
        private System.Windows.Forms.Button btnTongSoChan;
        private System.Windows.Forms.Button btnSoLuongUocSo;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Button btnExit;
    }
}