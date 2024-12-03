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
    public partial class C1_Bai9 : Form
    {
        public C1_Bai9()
        {
            InitializeComponent();
        }

        private void Bai9_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in lbClassA.Items)
            {
                lbClassB.Items.Add(item);
            }
            lbClassA.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                if (cbClass.SelectedItem == "Lớp A")
                {
                    lbClassA.Items.Add(txtName.Text);
                }else if (cbClass.SelectedItem == "Lớp B")
                {
                    lbClassB.Items.Add(txtName.Text);
                }
                else
                {
                    MessageBox.Show("vui lòng chọn lớp", "Thông báo");
                    cbClass.SelectedIndex = 0;
                }
            }
        }

        private void btnSwitchAForB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbClassA.SelectedItems.Count; i++)
            {

                lbClassB.Items.Add(lbClassA.SelectedItems[i]);
            }
            while (lbClassA.SelectedItems.Count != 0)
            {
                lbClassA.Items.Remove(lbClassA.SelectedItems[0]);
            }
        }

        private void btnSwitchBForA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbClassB.SelectedItems.Count; i++)
            {

                lbClassA.Items.Add(lbClassB.SelectedItems[i]);
            }
            while (lbClassB.SelectedItems.Count != 0)
            {
                lbClassB.Items.Remove(lbClassB.SelectedItems[0]);
            }
        }

        private void btnSwitchsBForA_Click(object sender, EventArgs e)
        {
            foreach (var item in lbClassB.Items)
            {
                lbClassA.Items.Add((string)item);
            }
            lbClassB.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (lbClassA.SelectedItems.Count != 0)
            {
                lbClassA.Items.Remove(lbClassA.SelectedItems[0]);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai9_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }
    }
}
