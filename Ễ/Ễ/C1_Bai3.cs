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
    public partial class C1_Bai3 : Form
    {
        public C1_Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNumber1.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber1.Text.Length - 1) && (txtNumber2.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber2.Text.Length - 1)))
            {
                int tong = int.Parse(txtNumber1.Text) + int.Parse(txtNumber2.Text);
                txtResult.Text = tong.ToString();

            }
        }

        private void rdTru_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNumber1.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber1.Text.Length - 1) && (txtNumber2.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber2.Text.Length - 1)))
            {
                int hieu = int.Parse(txtNumber1.Text) - int.Parse(txtNumber2.Text);
                txtResult.Text = hieu.ToString();
            }
        }

        private void rdNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNumber1.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber1.Text.Length - 1) && (txtNumber2.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber2.Text.Length - 1)))
            {
                int tich = int.Parse(txtNumber1.Text) * int.Parse(txtNumber2.Text);
                txtResult.Text = tich.ToString();
            }
        }

        private void txtNumber1_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (txtNumber1.Text.Trim().Length == 0 || !char.IsDigit(control.Text,control.Text.Length - 1))
            {
                errorProvider1.SetError(control, "vui lòng nhập đúng !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (txtNumber2.Text.Trim().Length == 0 || !char.IsDigit(control.Text, control.Text.Length - 1))
            {
                errorProvider1.SetError(control, "vui lòng nhập đúng !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void rdChia_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNumber1.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber1.Text.Length - 1) && (txtNumber2.Text.Trim().Length > 0 && char.IsDigit(txtNumber1.Text, txtNumber2.Text.Length - 1)))
                {
                if (txtNumber2.Text == "0")
                {
                    txtResult.Text = "Không thể chia";
                }
                else
                {
                    txtResult.Text = (double.Parse(txtNumber1.Text) / double.Parse(txtNumber2.Text)).ToString();
                }

            }
        }

        private void Bai3_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r = MessageBox.Show("bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) e.Cancel = true;
        }
    }
}
