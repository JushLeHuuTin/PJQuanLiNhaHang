namespace Ễ
{
    partial class C1_Bai9
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbClassA = new System.Windows.Forms.ListBox();
            this.btnSwitchAForB = new System.Windows.Forms.Button();
            this.btnSwitchsAForB = new System.Windows.Forms.Button();
            this.btnSwitchBForA = new System.Windows.Forms.Button();
            this.btnSwitchsBForA = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbClassB = new System.Windows.Forms.ListBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(230, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(411, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbClassA
            // 
            this.lbClassA.FormattingEnabled = true;
            this.lbClassA.Items.AddRange(new object[] {
            "Lê Hữu Tín",
            "Nguyễn Ngọc Doanh",
            "Nguyễn Gian Hà",
            "Trần Công Diệp"});
            this.lbClassA.Location = new System.Drawing.Point(27, 19);
            this.lbClassA.Name = "lbClassA";
            this.lbClassA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbClassA.Size = new System.Drawing.Size(167, 199);
            this.lbClassA.TabIndex = 4;
            // 
            // btnSwitchAForB
            // 
            this.btnSwitchAForB.Location = new System.Drawing.Point(292, 214);
            this.btnSwitchAForB.Name = "btnSwitchAForB";
            this.btnSwitchAForB.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchAForB.TabIndex = 4;
            this.btnSwitchAForB.Text = ">";
            this.btnSwitchAForB.UseVisualStyleBackColor = true;
            this.btnSwitchAForB.Click += new System.EventHandler(this.btnSwitchAForB_Click);
            // 
            // btnSwitchsAForB
            // 
            this.btnSwitchsAForB.Location = new System.Drawing.Point(292, 243);
            this.btnSwitchsAForB.Name = "btnSwitchsAForB";
            this.btnSwitchsAForB.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchsAForB.TabIndex = 5;
            this.btnSwitchsAForB.Text = ">>";
            this.btnSwitchsAForB.UseVisualStyleBackColor = true;
            this.btnSwitchsAForB.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSwitchBForA
            // 
            this.btnSwitchBForA.Location = new System.Drawing.Point(292, 272);
            this.btnSwitchBForA.Name = "btnSwitchBForA";
            this.btnSwitchBForA.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchBForA.TabIndex = 6;
            this.btnSwitchBForA.Text = "<";
            this.btnSwitchBForA.UseVisualStyleBackColor = true;
            this.btnSwitchBForA.Click += new System.EventHandler(this.btnSwitchBForA_Click);
            // 
            // btnSwitchsBForA
            // 
            this.btnSwitchsBForA.Location = new System.Drawing.Point(292, 301);
            this.btnSwitchsBForA.Name = "btnSwitchsBForA";
            this.btnSwitchsBForA.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchsBForA.TabIndex = 7;
            this.btnSwitchsBForA.Text = "<<";
            this.btnSwitchsBForA.UseVisualStyleBackColor = true;
            this.btnSwitchsBForA.Click += new System.EventHandler(this.btnSwitchsBForA_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(145, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(432, 413);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "&Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbClassA);
            this.groupBox1.Location = new System.Drawing.Point(75, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbClassB);
            this.groupBox2.Location = new System.Drawing.Point(373, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lóp B";
            // 
            // lbClassB
            // 
            this.lbClassB.FormattingEnabled = true;
            this.lbClassB.Location = new System.Drawing.Point(27, 19);
            this.lbClassB.Name = "lbClassB";
            this.lbClassB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbClassB.Size = new System.Drawing.Size(167, 199);
            this.lbClassB.TabIndex = 4;
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B"});
            this.cbClass.Location = new System.Drawing.Point(185, 131);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lớp";
            // 
            // C1_Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSwitchsBForA);
            this.Controls.Add(this.btnSwitchBForA);
            this.Controls.Add(this.btnSwitchsAForB);
            this.Controls.Add(this.btnSwitchAForB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "C1_Bai9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai9_FormClosing);
            this.Load += new System.EventHandler(this.Bai9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lbClassA;
        private System.Windows.Forms.Button btnSwitchAForB;
        private System.Windows.Forms.Button btnSwitchsAForB;
        private System.Windows.Forms.Button btnSwitchBForA;
        private System.Windows.Forms.Button btnSwitchsBForA;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbClassB;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label3;
    }
}