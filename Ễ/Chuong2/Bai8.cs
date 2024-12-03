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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            for(char i = 'A'; i <= 'Z'; i++)
            {
                tvMain.Nodes.Add(i.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tvMain.SelectedNode.Text.Length > 0){
               tvMain.SelectedNode.Nodes.Add(txtLastName.Text + "," + txtFirstName.Text);
            }
            else
            {
                MessageBox.Show("Bạn cần chọn tệp để thêm !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai8_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }
    }
}
