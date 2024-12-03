namespace Ễ
{
    partial class C1_Bai8
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSoLe = new System.Windows.Forms.Button();
            this.btnSoChan = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnIncrea = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteFirstLast = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(797, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "LIST BOX";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMain);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(121, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(23, 127);
            this.lbMain.Name = "lbMain";
            this.lbMain.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMain.Size = new System.Drawing.Size(205, 264);
            this.lbMain.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(205, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Nhập";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(23, 35);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(205, 30);
            this.txtInput.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSoLe);
            this.groupBox2.Controls.Add(this.btnSoChan);
            this.groupBox2.Controls.Add(this.btnReplace);
            this.groupBox2.Controls.Add(this.btnIncrea);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnDeleteFirstLast);
            this.groupBox2.Controls.Add(this.btnTong);
            this.groupBox2.Location = new System.Drawing.Point(438, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý Listbox";
            // 
            // btnSoLe
            // 
            this.btnSoLe.Location = new System.Drawing.Point(19, 356);
            this.btnSoLe.Name = "btnSoLe";
            this.btnSoLe.Size = new System.Drawing.Size(205, 35);
            this.btnSoLe.TabIndex = 12;
            this.btnSoLe.Text = "chọn số lẻ";
            this.btnSoLe.UseVisualStyleBackColor = true;
            this.btnSoLe.Click += new System.EventHandler(this.btnSoLe_Click);
            // 
            // btnSoChan
            // 
            this.btnSoChan.Location = new System.Drawing.Point(19, 306);
            this.btnSoChan.Name = "btnSoChan";
            this.btnSoChan.Size = new System.Drawing.Size(205, 35);
            this.btnSoChan.TabIndex = 11;
            this.btnSoChan.Text = "Chọn số chẵn";
            this.btnSoChan.UseVisualStyleBackColor = true;
            this.btnSoChan.Click += new System.EventHandler(this.btnSoChan_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(19, 247);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(205, 35);
            this.btnReplace.TabIndex = 10;
            this.btnReplace.Text = "Thay bằng bình phương";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnIncrea
            // 
            this.btnIncrea.Location = new System.Drawing.Point(19, 190);
            this.btnIncrea.Name = "btnIncrea";
            this.btnIncrea.Size = new System.Drawing.Size(205, 35);
            this.btnIncrea.TabIndex = 8;
            this.btnIncrea.Text = "Tăng mỗi phần tử lên 2";
            this.btnIncrea.UseVisualStyleBackColor = true;
            this.btnIncrea.Click += new System.EventHandler(this.btnIncrea_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(205, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa phần tử đang chọn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteFirstLast
            // 
            this.btnDeleteFirstLast.Location = new System.Drawing.Point(19, 89);
            this.btnDeleteFirstLast.Name = "btnDeleteFirstLast";
            this.btnDeleteFirstLast.Size = new System.Drawing.Size(205, 35);
            this.btnDeleteFirstLast.TabIndex = 6;
            this.btnDeleteFirstLast.Text = "Xóa phần tử đầu và cuối";
            this.btnDeleteFirstLast.UseVisualStyleBackColor = true;
            this.btnDeleteFirstLast.Click += new System.EventHandler(this.btnDeleteFirstLast_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(19, 35);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(205, 35);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tổng các phần tử trong List";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(563, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "KẾT THÚC";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // C1_Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "C1_Bai8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai8_FormClosing);
            this.Load += new System.EventHandler(this.Bai8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSoChan;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnIncrea;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteFirstLast;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSoLe;
    }
}