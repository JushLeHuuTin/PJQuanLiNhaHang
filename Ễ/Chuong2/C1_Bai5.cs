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
    public partial class C1_Bai5 : Form
    {
        public C1_Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void Bai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Times New Romans",txtResult.Font.Size,txtResult.Font.Style);
        }

        private void rdArial_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Arial", txtResult.Font.Size, txtResult.Font.Style);

        }

        private void rdTahoma_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Tahoma", txtResult.Font.Size, txtResult.Font.Style);

        }

        private void rdCourier_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Font = new Font("Courier New", txtResult.Font.Size, txtResult.Font.Style);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
