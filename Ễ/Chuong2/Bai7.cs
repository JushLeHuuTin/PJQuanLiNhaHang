using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong2
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (txtSoCu.Text.Trim().Length>0 && char.IsDigit(txtSoCu.Text,txtSoCu.Text.Length-1)
                && txtsSoMoi.Text.Trim().Length > 0 && char.IsDigit(txtsSoMoi.Text, txtsSoMoi.Text.Length - 1) && txtDinhMuc.Text != "" && int.Parse(txtSoCu.Text)<int.Parse(txtsSoMoi.Text))
            {
                double dienNangTieuThu = double.Parse(txtsSoMoi.Text.ToString()) - double.Parse(txtSoCu.Text.ToString());
                if (dienNangTieuThu <= int.Parse(txtDinhMuc.Text.ToString()))
                {
                    txtResult.Text = (dienNangTieuThu * 500).ToString();
                    txtConsume.Text = dienNangTieuThu.ToString();
                }
                else
                {
                    double ngoaiDM = dienNangTieuThu - int.Parse(txtDinhMuc.Text.ToString());
                    txtResult.Text = (int.Parse(txtDinhMuc.Text.ToString()) * 500  + ngoaiDM *1000).ToString();
                    txtConsume.Text = dienNangTieuThu.ToString();
                }
                ListViewItem item = new ListViewItem();
                item.Text = txtCustumer.Text;
                item.SubItems.Add(cbLocation.SelectedItem.ToString());
                item.SubItems.Add(txtDinhMuc.Text);
                item.SubItems.Add(txtConsume.Text);
                item.SubItems.Add(txtResult.Text);
                lvMain.Items.Add(item);

                txtTotalCost.Text =( double.Parse(txtTotalCost.Text ==""?"0":txtTotalCost.Text) + double.Parse(txtResult.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ !");
            }
        }

        private void txtDinhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocation.SelectedItem.ToString() != "")
            {
                if (cbLocation.SelectedItem.ToString() == "Khu vực 1")
                {
                    txtDinhMuc.Text = "50";
                }else if(cbLocation.SelectedItem.ToString() == "Khu vực 2")
                {
                    txtDinhMuc.Text = "100";
                }else {
                    txtDinhMuc.Text = "150";
                }
            }
            else
            {
                txtDinhMuc.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtConsume.Clear();
            txtCustumer.Clear();
            txtDinhMuc.Clear();
            txtResult.Clear();
            txtsSoMoi.Clear();
            txtSoCu.Clear();
            txtCustumer.Focus();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCustumer;
            txtCustumer.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa thông tin này ?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    txtTotalCost.Text = (int.Parse(txtTotalCost.Text) - int.Parse(lvMain.SelectedItems[0].SubItems[4].Text)).ToString();
                    lvMain.Items.Remove(lvMain.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thông tin cần xóa !");
            }
        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
