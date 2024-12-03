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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvMain.View = View.SmallIcon;
        }

        private void larrgeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvMain.View = View.LargeIcon;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtLastName.Text.Trim().Length != 0 && txtFirstName.Text.Trim().Length != 0 && txtPhone.Text.Trim().Length != 0)
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtLastName.Text;
                item.SubItems.Add(txtFirstName.Text);
                item.SubItems.Add(txtPhone.Text);
                lvMain.Items.Add(item);
                item.ImageIndex = 0;
                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
                txtLastName.Focus();
            }
        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count>0)
            {
                ListViewItem item = lvMain.SelectedItems[0];
               txtLastName.Text = item.Text;
                txtFirstName.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvMain.View = View.Details;
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
           DialogResult r = colorDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                lvMain.BackColor = colorDialog.Color;
            }
        }

        private void Bai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel) { e.Cancel = true; }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lvMain.Items.Count > 0)
            {
               DialogResult r = MessageBox.Show("Bạn có muốn lưu dữ liệu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                       Stream stream = saveFileDialog.OpenFile();
                       StreamWriter streamWriter = new StreamWriter(stream);
                        foreach (ListViewItem item in lvMain.Items)
                        {
                            string line = item.Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text;
                            streamWriter.WriteLine(line);
                        }
                        streamWriter.Close();
                    }
                }
            }
            lvMain.Items.Clear();
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
                     string line = item.Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text;
                    streamWriter.WriteLine(line);
                }
                streamWriter.Close();
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult r = openFileDialog.ShowDialog();
            openFileDialog.Filter = "All File(*.*)|*.*|File Txt(*.txt)|*.txt";
            if (r == DialogResult.OK)
            {
                lvMain.Items.Clear();
                Stream stream = openFileDialog.OpenFile();
                StreamReader streamReader = new StreamReader(stream);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    ListViewItem item = new ListViewItem();
                    string[] arr = line.Split(',');
                    item.Text = arr[0];
                    item.SubItems.Add(arr[1]);
                    item.SubItems.Add(arr[2]);
                    lvMain.Items.Add(item);
                }
                streamReader.Close();
            }
        }
    }
}
