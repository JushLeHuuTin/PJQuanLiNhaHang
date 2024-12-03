namespace lehuutin_b5
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
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Nguyen Van Tuan");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Nguyen Thi Lan");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Nguyen Van Luong");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("THTH5A", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Le Nghiep");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("Tran Long");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Ly Hai");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("THTH5B", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Le Trung");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("TRon Thi Mai");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Tran Minh");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("THTH5C", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode101,
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Khoa tin học", new System.Windows.Forms.TreeNode[] {
            treeNode95,
            treeNode99,
            treeNode103});
            this.lvMain = new System.Windows.Forms.ListView();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvMain.FullRowSelect = true;
            this.lvMain.GridLines = true;
            this.lvMain.HideSelection = false;
            this.lvMain.Location = new System.Drawing.Point(198, 48);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(278, 314);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tvMain
            // 
            this.tvMain.Location = new System.Drawing.Point(12, 48);
            this.tvMain.Name = "tvMain";
            treeNode92.Name = "Node2";
            treeNode92.Text = "Nguyen Van Tuan";
            treeNode93.Name = "Node3";
            treeNode93.Text = "Nguyen Thi Lan";
            treeNode94.Name = "Node4";
            treeNode94.Text = "Nguyen Van Luong";
            treeNode95.Name = "Node1";
            treeNode95.Text = "THTH5A";
            treeNode96.Name = "Node8";
            treeNode96.Text = "Le Nghiep";
            treeNode97.Name = "Node9";
            treeNode97.Text = "Tran Long";
            treeNode98.Name = "Node10";
            treeNode98.Text = "Ly Hai";
            treeNode99.Name = "Node6";
            treeNode99.Text = "THTH5B";
            treeNode100.Name = "Node11";
            treeNode100.Text = "Le Trung";
            treeNode101.Name = "Node12";
            treeNode101.Text = "TRon Thi Mai";
            treeNode102.Name = "Node13";
            treeNode102.Text = "Tran Minh";
            treeNode103.Name = "Node7";
            treeNode103.Text = "THTH5C";
            treeNode104.Name = "Node0";
            treeNode104.Text = "Khoa tin học";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode104});
            this.tvMain.Size = new System.Drawing.Size(180, 314);
            this.tvMain.TabIndex = 1;
            this.tvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.tvMain.DoubleClick += new System.EventHandler(this.tvMain_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 29);
            this.panel1.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(64, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nhập tên: ";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(127, 7);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.Enter += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(233, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 22);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TenSV";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lop";
            // 
            // Bai9
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvMain);
            this.Controls.Add(this.lvMain);
            this.Name = "Bai9";
            this.Text = "Bai9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai9_FormClosing);
            this.Load += new System.EventHandler(this.Bai9_Load);
            this.Enter += new System.EventHandler(this.Bai9_Enter);
            this.MouseHover += new System.EventHandler(this.Bai9_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}