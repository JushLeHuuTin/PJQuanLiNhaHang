using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lehuutin_b5
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai9_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtFind;
            txtFind.Focus();
            tvMain.ExpandAll();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            findStudent(tvMain.SelectedNode,txtFind.Text);
        }
        private void findStudent(TreeNode node , string sName)
        {
            for (int i = 0; i < 3; i++)
            {
                if (node.Nodes[i].ToString().Contains(sName) == true)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = node.Nodes[i].Text.ToString();
                    item.SubItems.Add(node.Text.ToString());
                    lvMain.Items.Add(item);
                }
            }
        }

        private void tvMain_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = tvMain.SelectedNode.Text.ToString();
            item.SubItems.Add(tvMain.SelectedNode.Parent.Text.ToString());

            lvMain.Items.Add(item);
        }

        private void Bai9_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát phần mềm không ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            txtFind.Focus();
        }

        private void Bai9_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void Bai9_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
