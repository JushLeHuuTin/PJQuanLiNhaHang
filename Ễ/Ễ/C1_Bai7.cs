using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ễ
{
    public partial class C1_Bai7 : Form
    {
        public C1_Bai7()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text.Trim().Length > 0 && char.IsDigit(txtNumber.Text,txtNumber.Text.Length - 1))
            cbNumber.Items.Add(txtNumber.Text);
            txtNumber.Clear();
            txtNumber.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (var item in lbMain.Items)
            {
                tong += int.Parse(item.ToString());
            }
            MessageBox.Show($"Tong cac uoc la: {tong}");
        }

        private void cbNumber_Click(object sender, EventArgs e)
        {
        }

        private void cbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMain.Items.Clear();
            for (int i = 1; i<int.Parse(cbNumber.SelectedItem.ToString()); i++)
            {
                if (int.Parse(cbNumber.SelectedItem.ToString()) % i== 0)
                {
                       lbMain.Items.Add(i);
                }
            }
        }

        private void btnTongSoChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in lbMain.Items)
            {
                if (int.Parse(item.ToString()) % 2 == 0) count++;
            }
            MessageBox.Show("So luong cac uoc chan la " + count);
        }

        private void btnSoLuongUocSo_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in lbMain.Items)
            {
                if (kiemTraSNT(int.Parse(item.ToString())))
                {
                    count++;
                }

            }
            MessageBox.Show("So luong cac uoc so  nguyen to la " + count);
        }
        private bool kiemTraSNT(int number)
        {
            if(number <= 1) return false;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }  
        }
    }
}
