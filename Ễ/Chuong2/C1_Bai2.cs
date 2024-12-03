using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ễ
{
    public partial class C1_Bai2 : Form
    {
        public C1_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNumberA.Text);
            int b = int.Parse(txtNumberB.Text);
            string result = tinhPhuongTrinhBacNhat(a, b);
            txtResult.Text = result;
            btnSolve.Enabled = false;
        }
        //ham tinh nghiem bac 1
        private string tinhPhuongTrinhBacNhat(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0) return "Phương trình vô số nghiệm";
                else return "Phương trình vô nghiệm";
            }
            return (-b*1.0  / a * 1.0).ToString();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            txtNumberA.Clear();
            txtNumberB.Clear();
            txtResult.Clear();
            txtNumberA.Focus();
            btnDelete.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) e.Cancel = true;
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnSolve.Enabled = false;
        

        }

        private void txtNumberA_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (txtNumberA.Text.Trim().Length <= 0 || !char.IsDigit(control.Text,control.Text.Length-1))
            {
                errorProvider1.SetError(control,"Vui lòng nhập hợp lệ");
            }
            else
            {
                errorProvider1.Clear();
                btnSolve.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtNumberB_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (txtNumberB.Text.Trim().Length <= 0 || !char.IsDigit(control.Text, control.Text.Length - 1))
            {
                errorProvider1.SetError(control, "Vui lòng nhập hợp lệ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNumberA_TextChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
