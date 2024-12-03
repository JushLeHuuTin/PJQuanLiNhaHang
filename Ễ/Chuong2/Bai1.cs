using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string dateOfBirth = mtbDayogBirth.Text;
            string adrress = txtAdress.Text;
            string city = txtCity.Text;
            string qualification = txtQualification.Text;
            string phone = mtbPhone.Text;
            string email = txtEmail.Text;
            string dateJoin = dtJoin.Value.ToString();
            string msg = $"Name: {name} \nDate of birth: {dateOfBirth} \nadrrsess: {adrress} \nCity: {city} \nQualification: {qualification} \nPhone: {phone} \nEmail: {email} \nDateJoin: {dateJoin}";
            MessageBox.Show(msg);
        }

        private void Bai1_Load(object sender, EventArgs e)
        {
            cbCountry.Items.Add("(Select)");
            cbCountry.SelectedItem = "(Select)";
        }

        private void Bai1_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtName.Text.Trim().Length <= 0)
            {
               errorProvider1.SetError(txtName,"Không để trống trường này");
                txtName.Focus();
            }else
                errorProvider1.Clear();

        }

        private void mtbDayogBirth_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbDayogBirth_Leave(object sender, EventArgs e)
        {
            if (mtbDayogBirth.Text.Trim().Length <= 0)
            {
                errorProvider1.SetError(mtbDayogBirth, "Không để trống trường này");
                mtbDayogBirth.Focus();
            }else
                errorProvider1.Clear();

        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {
            if (txtAdress.Text.Trim().Length <= 0)
            {
                errorProvider1.SetError(txtAdress, "Không để trống trường này");
                txtAdress.Focus();
            }else
                errorProvider1.Clear();

        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim().Length <= 0)
            {
                errorProvider1.SetError(txtCity, "Không để trống trường này");
                txtCity.Focus();
            }else
                errorProvider1.Clear();

        }

        private void cbCountry_Leave(object sender, EventArgs e)
        {
            if (cbCountry.SelectedItem.ToString() == "(Select)")
            {
                errorProvider1.SetError(cbCountry, "Không để trống trường này");
                cbCountry.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo instance của Bai1 nếu chưa mở
                //Bai1 bai1Form = new Bai1();
                this.BackColor = colorDialog.Color; // Thay đổi màu nền
                //bai1Form.Show(); // Hiện form Bai1
            }
        }
    }
}
