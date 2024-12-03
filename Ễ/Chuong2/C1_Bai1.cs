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
    public partial class C1_Bai1 : Form
    {
        public C1_Bai1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0 && txtYear.Text.Trim().Length > 0 && char.IsDigit(txtYear.Text,txtYear.Text.Length - 1))
            {
                DateTime dateCurrent = DateTime.Now;
                int yearOld = dateCurrent.Year - int.Parse(txtYear.Text);
                String message = txtName.Text + " " + yearOld + " tuổi"; 
                DialogResult r = MessageBox.Show(message, "Thông báo");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtYear.Clear() ;
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) e.Cancel = true;
        }

        private void Bai1_Leave(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length == 0)
            {
                Control ctr = (Control)sender;
                errorProvider1.SetError(ctr,"Vui lòng không bỏ trống");
            }else{
                errorProvider1.Clear();
            }
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (txtYear.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Vui lòng không bỏ trống");
            }
            else if (char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                errorProvider1.SetError(ctr, "Vui lòng nhập số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
