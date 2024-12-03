namespace Ễ
{
    partial class C1_Bai5
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rdTimes = new System.Windows.Forms.RadioButton();
            this.rdArial = new System.Windows.Forms.RadioButton();
            this.rdTahoma = new System.Windows.Forms.RadioButton();
            this.rdCourier = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản:";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(100, 94);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(160, 177);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "WHAT FONT IS THIS?";
            // 
            // rdTimes
            // 
            this.rdTimes.AutoSize = true;
            this.rdTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTimes.Location = new System.Drawing.Point(375, 94);
            this.rdTimes.Name = "rdTimes";
            this.rdTimes.Size = new System.Drawing.Size(160, 24);
            this.rdTimes.TabIndex = 2;
            this.rdTimes.TabStop = true;
            this.rdTimes.Text = "Times New Roman";
            this.rdTimes.UseVisualStyleBackColor = true;
            this.rdTimes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdArial
            // 
            this.rdArial.AutoSize = true;
            this.rdArial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdArial.Location = new System.Drawing.Point(375, 143);
            this.rdArial.Name = "rdArial";
            this.rdArial.Size = new System.Drawing.Size(58, 24);
            this.rdArial.TabIndex = 3;
            this.rdArial.TabStop = true;
            this.rdArial.Text = "Arial";
            this.rdArial.UseVisualStyleBackColor = true;
            this.rdArial.CheckedChanged += new System.EventHandler(this.rdArial_CheckedChanged);
            // 
            // rdTahoma
            // 
            this.rdTahoma.AutoSize = true;
            this.rdTahoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTahoma.Location = new System.Drawing.Point(375, 197);
            this.rdTahoma.Name = "rdTahoma";
            this.rdTahoma.Size = new System.Drawing.Size(85, 24);
            this.rdTahoma.TabIndex = 4;
            this.rdTahoma.TabStop = true;
            this.rdTahoma.Text = "Tahoma";
            this.rdTahoma.UseVisualStyleBackColor = true;
            this.rdTahoma.CheckedChanged += new System.EventHandler(this.rdTahoma_CheckedChanged);
            // 
            // rdCourier
            // 
            this.rdCourier.AutoSize = true;
            this.rdCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCourier.Location = new System.Drawing.Point(375, 254);
            this.rdCourier.Name = "rdCourier";
            this.rdCourier.Size = new System.Drawing.Size(113, 24);
            this.rdCourier.TabIndex = 5;
            this.rdCourier.TabStop = true;
            this.rdCourier.Text = "Courier New";
            this.rdCourier.UseVisualStyleBackColor = true;
            this.rdCourier.CheckedChanged += new System.EventHandler(this.rdCourier_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(163, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // C1_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rdCourier);
            this.Controls.Add(this.rdTahoma);
            this.Controls.Add(this.rdArial);
            this.Controls.Add(this.rdTimes);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Name = "C1_Bai5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai5_FormClosing);
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rdTimes;
        private System.Windows.Forms.RadioButton rdArial;
        private System.Windows.Forms.RadioButton rdTahoma;
        private System.Windows.Forms.RadioButton rdCourier;
        private System.Windows.Forms.Button btnExit;
    }
}