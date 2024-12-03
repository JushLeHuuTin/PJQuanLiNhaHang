using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMaSV.Clear();
            txtAdrress.Clear();
            txtClass.Clear();
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtMaSV.Text;
            item.SubItems.Add(txtName.Text);
            item.SubItems.Add(txtAdrress.Text);
            item.SubItems.Add(dtDayOfBirth.Value.ToShortDateString().ToString());
            item.SubItems.Add(txtClass.Text);
            item.ImageIndex = 0;
            if (txtMaSV.Text != "" && txtName.Text != "" && txtAdrress.Text != "" && dtDayOfBirth.Value.ToString() != "" && txtClass.Text != "")
            {
                lvMain.Items.Add(item);

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắn muốn xóa", "Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    while (lvMain.SelectedItems.Count > 0)
                    {
                        lvMain.Items.Remove(lvMain.SelectedItems[0]);
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa bạn sinh viên cần xóa !");
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All File(*.*)|*.*|File txt(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lvMain.Items.Clear();
                Stream stream = openFileDialog.OpenFile();
                StreamReader streamReader = new StreamReader(stream);
                string line;
                while ((line = streamReader.ReadLine())!= null)
                {
                    string[] arr = line.Split(',');
                    ListViewItem  item = new ListViewItem();
                    item.Text = arr[0];
                    item.SubItems.Add(arr[1]);
                    item.SubItems.Add(arr[2]);
                    item.SubItems.Add(arr[3]);
                    item.SubItems.Add(arr[4]);
                    lvMain.Items.Add(item);
                }
                streamReader.Close();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter streamWriter = new StreamWriter(stream);
                foreach (ListViewItem item in lvMain.Items)
                {
                    streamWriter.WriteLine(item.Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text + "," + item.SubItems[4].Text);
                }
                streamWriter.Close();
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMain.Items.Count > 0)
            {
               if(MessageBox.Show("Bạn có muốn lưu dữ liệu ?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveFileToolStripMenuItem_Click(sender,e);
                }
            }
            lvMain.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) e.Cancel = true;
        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count >0)
            {
                txtMaSV.Text = lvMain.SelectedItems[0].Text;
                txtName.Text = lvMain.SelectedItems[0].SubItems[1].Text;
                txtAdrress.Text = lvMain.SelectedItems[0].SubItems[2].Text;
                dtDayOfBirth.Text = lvMain.SelectedItems[0].SubItems[3].Text;
                txtClass.Text = lvMain.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvMain.View = View.Details;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvMain.View = View.SmallIcon;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvMain.View = View.LargeIcon;
        }
    }
}
