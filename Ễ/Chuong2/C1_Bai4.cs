using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ễ
{
    public partial class C1_Bai4 : Form
    {
        public C1_Bai4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Red;
            lbResult.ForeColor = Color.Red;
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Green;
            txtName.ForeColor = Color.Green;
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Blue;
            txtName.ForeColor = Color.Blue;
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.ForeColor = Color.Black;
            txtName.ForeColor = Color.Black;
        }

        private void cbDam_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.Font = new Font( lbResult.Font.Name,lbResult.Font.Size,lbResult.Font.Style ^ FontStyle.Bold);
        }

        private void cbNghien_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.Font = new Font(lbResult.Font.Name, lbResult.Font.Size, lbResult.Font.Style ^ FontStyle.Italic);

        }

        private void cbGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lbResult.Font = new Font(lbResult.Font.Name, lbResult.Font.Size, lbResult.Font.Style ^ FontStyle.Underline);

        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
            txtName.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lbResult.Text = txtName.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) e.Cancel = true;

        }
    }
}
