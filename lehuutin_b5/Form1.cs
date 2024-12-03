using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lehuutin_b5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNode(tvMain.SelectedNode,txtName.Text);
        }
        private void addNode(TreeNode node, string sName)
        {
            node.Nodes.Add(sName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tvMain.Nodes.Remove(tvMain.SelectedNode);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                tvMain.Nodes.Add(i.ToString());
            }
        }

        private void tvMain_DoubleClick(object sender, EventArgs e)
        {
            tvMain.SelectedNode.ImageIndex = 2;
        }
    }
}
