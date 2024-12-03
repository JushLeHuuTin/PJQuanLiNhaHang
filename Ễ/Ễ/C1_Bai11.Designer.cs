namespace Ễ
{
    partial class C1_Bai11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBlack = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlack = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBlack);
            this.panel1.Controls.Add(this.txtGreen);
            this.panel1.Controls.Add(this.txtRed);
            this.panel1.Controls.Add(this.tbGreen);
            this.panel1.Controls.Add(this.tbBlack);
            this.panel1.Controls.Add(this.tbRed);
            this.panel1.Location = new System.Drawing.Point(138, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 152);
            this.panel1.TabIndex = 0;
            // 
            // txtBlack
            // 
            this.txtBlack.Location = new System.Drawing.Point(109, 107);
            this.txtBlack.Multiline = true;
            this.txtBlack.Name = "txtBlack";
            this.txtBlack.Size = new System.Drawing.Size(97, 45);
            this.txtBlack.TabIndex = 2;
            this.txtBlack.Text = "B = 0";
            this.txtBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(109, 58);
            this.txtGreen.Multiline = true;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(97, 48);
            this.txtGreen.TabIndex = 2;
            this.txtGreen.Text = "G = 0";
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(109, 6);
            this.txtRed.Multiline = true;
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(97, 52);
            this.txtRed.TabIndex = 2;
            this.txtRed.Text = "R = 0";
            this.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(3, 57);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(104, 45);
            this.tbGreen.TabIndex = 1;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // tbBlack
            // 
            this.tbBlack.Location = new System.Drawing.Point(3, 107);
            this.tbBlack.Name = "tbBlack";
            this.tbBlack.Size = new System.Drawing.Size(104, 45);
            this.tbBlack.TabIndex = 1;
            this.tbBlack.Scroll += new System.EventHandler(this.tbBlack_Scroll);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(3, 6);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(104, 45);
            this.tbRed.TabIndex = 0;
            this.tbRed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(350, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 152);
            this.panel2.TabIndex = 1;
            // 
            // C1_Bai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "C1_Bai11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai11";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai11_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlack;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TextBox txtBlack;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Panel panel2;
    }
}