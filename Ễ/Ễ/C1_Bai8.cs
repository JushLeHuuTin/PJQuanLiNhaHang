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
    public partial class C1_Bai8 : Form
    {
        public C1_Bai8()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "" && char.IsDigit(txtInput.Text,txtInput.Text.Length - 1))
            {
                lbMain.Items.Add(txtInput.Text);
                txtInput.Clear();
                txtInput.Focus();

            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lbMain.Items)
            {
                sum += int.Parse(item.ToString());
            }
            MessageBox.Show($"Tông các phân tử trong list là {sum}");
        }

        private void btnDeleteFirstLast_Click(object sender, EventArgs e)
        {
            if (lbMain.Items.Count >= 2)
            {
                lbMain.Items.RemoveAt(0);
                lbMain.Items.RemoveAt(lbMain.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Mang ít hơn 2 phần tử !")
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while(lbMain.SelectedItems.Count != 0){
                lbMain.Items.Remove(lbMain.SelectedItems[0]);
            }
        }

        private void btnIncrea_Click(object sender, EventArgs e)
        {
            int[] arr = new int[lbMain.Items.Count];
            for (int i = 0; i < lbMain.Items.Count; i++)
            {
                arr[i] = int.Parse(lbMain.Items[i].ToString()) + 2;
            }
            lbMain.Items.Clear();
            foreach (var item in arr)
            {
                lbMain.Items.Add(item);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lbMain.Items.Count; i++)
            {
                lbMain.Items[i] = Math.Pow(double.Parse(lbMain.Items[i].ToString()),2);
            }
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < lbMain.Items.Count; i++)
            {
                if (int.Parse(lbMain.Items[i].ToString()) % 2 == 0) lbMain.SetSelected(i, true);
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbMain.Items.Count; i++)
            {
                if (int.Parse(lbMain.Items[i].ToString()) % 2 != 0) lbMain.SetSelected(i, true);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai8_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtInput;
            txtInput.Focus();
        }
    }
}
