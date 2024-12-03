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
    public partial class C1_Bai6 : Form
    {
        public C1_Bai6()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
       
            pbMain.Image = imgList.Images[0];

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdUSA_CheckedChanged(object sender, EventArgs e)
        {
            pbMain.Image = imgList.Images[1];
        }

        private void rdItalia_CheckedChanged(object sender, EventArgs e)
        {
            pbMain.Image = imgList.Images[2];
        }

        private void rdPhilippine_CheckedChanged(object sender, EventArgs e)
        {
            pbMain.Image = imgList.Images[3];
        }

        private void Bai6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }

        private void C1_Bai6_Load(object sender, EventArgs e)
        {
            rsVietNam.Checked = true;
        }
    }
}
