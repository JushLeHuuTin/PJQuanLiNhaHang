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
    public partial class C1_Bai10 : Form
    {
        public C1_Bai10()
        {
            InitializeComponent();
        }

        private void Bai10_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i < 2024; i++)
            {
                cbYear.Items.Add(i.ToString());
            }
            for (int i = 1; i < 11; i++)
            {
                cbClass.Items.Add("TH" + i.ToString()); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string cl = cbClass.Text;
            string year = cbYear.Text;
            string term = "";
            if (rdFour.Checked == true) term = "4";
            else if (rdThree.Checked) term = "3";
            else if (rdTwo.Checked == true)term = "2";
            else term = "1";
            string courses = "";
            for(int i = 0; i < clbCourse.CheckedItems.Count; i++)
            {
                courses += $"{i+1}. {clbCourse.CheckedItems[i]} \n";
            }
            string msg = $"Sinh viên: {name} \nLớp: {cl} \nNiên khóa: {year} \nĐã đăng ký học kỳ {term} các môn sau: \n{courses}";
            if (name != "" && cl != "" && year != "" && term != "" && courses != "")
            {
                MessageBox.Show(msg);

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtName.Clear();
            cbYear.SelectedIndex = -1;
            cbClass.SelectedIndex = -1;
            clbCourse.Select();
            rdI.Checked = true;
            for (int i = 0; i < clbCourse.Items.Count; i++)
            { 
               clbCourse.SetItemChecked(i, false);
                clbCourse.SetSelected(i,false);
            }
            txtMaSV.Focus();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai10_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }
    }
}
