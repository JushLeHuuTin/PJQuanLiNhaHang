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
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim().Length>0 && txtName.Text.Trim().Length > 0 && txtAdrress.Text.Trim().Length>0)
            {
                if (!tvMain.SelectedNode.Text.Contains("Danh sách lớp") && tvMain.SelectedNode.Parent.Text.Contains("Danh sách lớp"))
                {
                    if (checkMaSV(tvMain.Nodes[0], txtMaSV.Text))
                    {
                        tvMain.SelectedNode.Nodes.Add(txtMaSV.Text + "-" + txtName.Text);
                        tvMain.SelectedNode.LastNode.Nodes.Add(txtAdrress.Text);
                    }
                    else MessageBox.Show("Mã sinh viên đã có trong danh sách !");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lớp để thêm !");
                }
             }
        }
        private bool checkMaSV(TreeNode node,string maSV)
        {

            foreach (TreeNode Child in node.Nodes)
            {
                foreach (TreeNode item in Child.Nodes)
                {
                    if (item.Text.Split('-')[0] == maSV)
                    { return false; }
                }
            }
            return true;
        }

        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (char.IsDigit(tvMain.SelectedNode.Text.Split('-')[0], tvMain.SelectedNode.Text.Split('-')[0].Length - 1))
            {
               txtAdrress.Text = tvMain.SelectedNode.Nodes[0].Text;
                txtMaSV.Text = tvMain.SelectedNode.Text.Split('-')[0];
                txtName.Text = tvMain.SelectedNode.Text.Split('-')[1];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (char.IsDigit(tvMain.SelectedNode.Text.Split('-')[0], tvMain.SelectedNode.Text.Split('-')[0].Length - 1))
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tệp sinh viên này ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    tvMain.Nodes.Remove(tvMain.SelectedNode);
                }
            }
            else MessageBox.Show("Vui lòng chọn sinh viên để xóa !");
        }

        private void Bai10_Load(object sender, EventArgs e)
        {
            tvMain.ExpandAll();
            this.ActiveControl = txtMaSV;
            txtMaSV.Focus();
        }

        private void Bai10_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }
    }
}
