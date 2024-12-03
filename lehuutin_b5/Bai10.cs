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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai10_Load(object sender, EventArgs e)
        {
            tvMain.ExpandAll();
            
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {
            Control ctl = (Control)sender;
            if (ctl.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtMaSV,"Không được để trống");
            }
            else if(!checkMaSV(tvMain.SelectedNode,txtMaSV.Text))
            {
                this.errorProvider1.SetError(txtMaSV, "Mã sinh viên đã tồn tại");

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private bool checkMaSV(TreeNode node,string maSV)
        {
            foreach (TreeNode child in node.Nodes)
            {
                string[] arra = child.Text.ToString().Split('-');
                if (arra[0] == maSV)
                {
                    return false;
                }
            }
            return true;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Control ctl = (Control)sender;
            if (ctl.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtName, "Không được để trống");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Control ctl = (Control)sender;
            if (ctl.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtAddress, "Không được để trống");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TreeNode node = tvMain.SelectedNode;
            if (!node.Text.ToString().Contains('-') && node.Text.Length == 7)
            {

                node.Nodes.Add(txtMaSV.Text.ToString() + "-" + txtName.Text.ToString());
                node.LastNode.Nodes.Add(txtAddress.Text.ToString());
            }
        }

        private void tvMain_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode.Text.Contains("-"))
            {
                string[] arr = tvMain.SelectedNode.Text.ToString().Split('-');
                txtMaSV.Text = arr[0];
                txtName.Text = arr[1];
                txtAddress.Text = tvMain.SelectedNode.LastNode.Text.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode.Text.ToString().Contains('-'))
            {
                tvMain.Nodes.Remove(tvMain.SelectedNode);
            }
        }
    }
}
