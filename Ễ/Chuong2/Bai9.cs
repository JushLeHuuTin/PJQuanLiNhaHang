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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void Bai9_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            tvMain.ExpandAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode.Nodes.Count > 0)
            {
                lvMain.Items.Clear();
                if (tvMain.SelectedNode.Nodes[0].Text.ToString().Contains("THTH"))
                {
                    foreach (TreeNode item in tvMain.SelectedNode.Nodes)
                    {
                        foreach (TreeNode itemChild in item.Nodes)
                        {
                            if (itemChild.Text.Contains(txtFind.Text))
                            {
                                ListViewItem listViewItem = new ListViewItem();
                                listViewItem.Text = itemChild.Text;
                                listViewItem.SubItems.Add(itemChild.Parent.Text);
                                lvMain.Items.Add(listViewItem);
                            }
                        }
                    }
                }
                else
                {
                    foreach (TreeNode item in tvMain.SelectedNode.Nodes)
                    {
                        if (item.Text.Contains(txtFind.Text))
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.Text = item.Text;
                            listViewItem.SubItems.Add(item.Parent.Text);
                            lvMain.Items.Add(listViewItem);
                        }
                    }
                }
            }
            else
            {
                lvMain.Items.Clear ();
                if (tvMain.SelectedNode.Text.Contains(txtFind.Text))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = tvMain.SelectedNode.Text;
                    listViewItem.SubItems.Add(tvMain.SelectedNode.Parent.Text);
                    lvMain.Items.Add(listViewItem);
                }
            }
        }

        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvMain.SelectedNode.Nodes.Count > 0)
            {
                if (tvMain.SelectedNode.Nodes[0].Text.ToString().Contains("THTH")) 
                {
                    foreach  (TreeNode item  in tvMain.SelectedNode.Nodes)
                    {
                        foreach (TreeNode value in item.Nodes)
                        {
                            ListViewItem listViewItem = new ListViewItem();
                            listViewItem.Text = value.Text;
                            listViewItem.SubItems.Add(item.Text);

                            lvMain.Items.Add(listViewItem);

                        }
                    
                    }
 
                }
                else if (tvMain.SelectedNode.Text.Contains("THTH")){
                    lvMain.Items.Clear();
                    foreach (TreeNode item in tvMain.SelectedNode.Nodes)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = item.Text;
                        listViewItem.SubItems.Add(item.Parent.Text);
                        lvMain.Items.Add(listViewItem);
                    }
            
                }
            }
            else
            {
                lvMain.Items.Clear();
                ListViewItem item = new ListViewItem();
                item.Text = tvMain.SelectedNode.Text;
                item.SubItems.Add(tvMain.SelectedNode.Parent.Text);
                lvMain.Items.Add(item);
            }
        }

        private void Bai9_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }
    }
}
