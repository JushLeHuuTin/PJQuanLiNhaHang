namespace Ễ
{
    partial class C1_Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C1_Bai6));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPhilippine = new System.Windows.Forms.RadioButton();
            this.rdItalia = new System.Windows.Forms.RadioButton();
            this.rdUSA = new System.Windows.Forms.RadioButton();
            this.rdVietNam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(766, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "COUNTRY FLAGS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPhilippine);
            this.groupBox1.Controls.Add(this.rdItalia);
            this.groupBox1.Controls.Add(this.rdUSA);
            this.groupBox1.Controls.Add(this.rdVietNam);
            this.groupBox1.Location = new System.Drawing.Point(78, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdPhilippine
            // 
            this.rdPhilippine.AutoSize = true;
            this.rdPhilippine.Location = new System.Drawing.Point(58, 246);
            this.rdPhilippine.Name = "rdPhilippine";
            this.rdPhilippine.Size = new System.Drawing.Size(70, 17);
            this.rdPhilippine.TabIndex = 4;
            this.rdPhilippine.TabStop = true;
            this.rdPhilippine.Text = "Philippine";
            this.rdPhilippine.UseVisualStyleBackColor = true;
            this.rdPhilippine.CheckedChanged += new System.EventHandler(this.rdPhilippine_CheckedChanged);
            // 
            // rdItalia
            // 
            this.rdItalia.AutoSize = true;
            this.rdItalia.Location = new System.Drawing.Point(58, 182);
            this.rdItalia.Name = "rdItalia";
            this.rdItalia.Size = new System.Drawing.Size(47, 17);
            this.rdItalia.TabIndex = 3;
            this.rdItalia.TabStop = true;
            this.rdItalia.Text = "Italia";
            this.rdItalia.UseVisualStyleBackColor = true;
            this.rdItalia.CheckedChanged += new System.EventHandler(this.rdItalia_CheckedChanged);
            // 
            // rdUSA
            // 
            this.rdUSA.AutoSize = true;
            this.rdUSA.Location = new System.Drawing.Point(58, 115);
            this.rdUSA.Name = "rdUSA";
            this.rdUSA.Size = new System.Drawing.Size(47, 17);
            this.rdUSA.TabIndex = 2;
            this.rdUSA.TabStop = true;
            this.rdUSA.Text = "USA";
            this.rdUSA.UseVisualStyleBackColor = true;
            this.rdUSA.CheckedChanged += new System.EventHandler(this.rdUSA_CheckedChanged);
            // 
            // rdVietNam
            // 
            this.rdVietNam.AutoSize = true;
            this.rdVietNam.Location = new System.Drawing.Point(58, 47);
            this.rdVietNam.Name = "rdVietNam";
            this.rdVietNam.Size = new System.Drawing.Size(65, 17);
            this.rdVietNam.TabIndex = 1;
            this.rdVietNam.TabStop = true;
            this.rdVietNam.Text = "VietNam";
            this.rdVietNam.UseVisualStyleBackColor = true;
            this.rdVietNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.ImageLocation = "";
            this.pbMain.Location = new System.Drawing.Point(388, 136);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(251, 201);
            this.pbMain.TabIndex = 5;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Vietnam.jpg");
            this.imgList.Images.SetKeyName(1, "My.jpg");
            this.imgList.Images.SetKeyName(2, "Italia.jpg");
            this.imgList.Images.SetKeyName(3, "Philippine.jpg");
            // 
            // C1_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "C1_Bai6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai6_FormClosing);
            this.Load += new System.EventHandler(this.C1_Bai6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPhilippine;
        private System.Windows.Forms.RadioButton rdItalia;
        private System.Windows.Forms.RadioButton rdUSA;
        private System.Windows.Forms.RadioButton rdVietNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.ImageList imgList;
    }
}