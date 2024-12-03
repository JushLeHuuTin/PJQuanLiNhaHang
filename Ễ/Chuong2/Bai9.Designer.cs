namespace Chuong2
{
    partial class Bai9
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Nguyen Van Tuan");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Nguyen Thi Lan");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Nguyen Van Luong");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("THTH5A", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Le Nghiep");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tran Long");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Ly Hai");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("THTH5B", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Le Trung");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Le Thi Mai");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Tran Minh");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("THTH5C", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Khoa Tin Học", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21,
            treeNode25});
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvMain);
            this.panel2.Location = new System.Drawing.Point(341, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 376);
            this.panel2.TabIndex = 1;
            // 
            // lvMain
            // 
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvMain.FullRowSelect = true;
            this.lvMain.GridLines = true;
            this.lvMain.HideSelection = false;
            this.lvMain.Location = new System.Drawing.Point(3, 3);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(333, 373);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ten SV";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lop";
            this.columnHeader2.Width = 170;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tvMain);
            this.panel3.Location = new System.Drawing.Point(3, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 376);
            this.panel3.TabIndex = 1;
            // 
            // tvMain
            // 
            this.tvMain.Location = new System.Drawing.Point(3, 0);
            this.tvMain.Name = "tvMain";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Nguyen Van Tuan";
            treeNode15.Name = "Node3";
            treeNode15.Text = "Nguyen Thi Lan";
            treeNode16.Name = "Node5";
            treeNode16.Text = "Nguyen Van Luong";
            treeNode17.Name = "Node1";
            treeNode17.Text = "THTH5A";
            treeNode18.Name = "Node7";
            treeNode18.Text = "Le Nghiep";
            treeNode19.Name = "Node8";
            treeNode19.Text = "Tran Long";
            treeNode20.Name = "Node9";
            treeNode20.Text = "Ly Hai";
            treeNode21.Name = "Node6";
            treeNode21.Text = "THTH5B";
            treeNode22.Name = "Node11";
            treeNode22.Text = "Le Trung";
            treeNode23.Name = "Node12";
            treeNode23.Text = "Le Thi Mai";
            treeNode24.Name = "Node13";
            treeNode24.Text = "Tran Minh";
            treeNode25.Name = "Node10";
            treeNode25.Text = "THTH5C";
            treeNode26.Name = "Node0";
            treeNode26.Text = "Khoa Tin Học";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.tvMain.Size = new System.Drawing.Size(326, 373);
            this.tvMain.TabIndex = 0;
            this.tvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(401, 33);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(157, 20);
            this.txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(602, 31);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 454);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Bai9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai9_FormClosing);
            this.Load += new System.EventHandler(this.Bai9_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}