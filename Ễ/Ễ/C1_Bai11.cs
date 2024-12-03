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
    public partial class C1_Bai11 : Form
    {
        public C1_Bai11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            txtRed.Text = "R = " + tbRed.Value.ToString();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Green;
            txtGreen.Text = "G = " + tbGreen.Value.ToString();
        }

        private void tbBlack_Scroll(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            txtBlack.Text = "B = " + tbBlack.Value.ToString();
        }

        private void Bai11_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }
    }
}
