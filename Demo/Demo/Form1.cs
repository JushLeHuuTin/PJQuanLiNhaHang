using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Demo
{
    public partial class Form1 : Form
    {
        Dataprovider dataprovider = new Dataprovider();
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtMaKhoa;
            txtMaKhoa.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = LoadKhoa();
        }
        private DataTable LoadKhoa()
        {
            //DataTable table = new DataTable();
            string sql = "ps_hienthikhoa";
           return  dataprovider.executeQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim().Length > 0)
            {
                    string sql = "ps_themkhoa";
                    SqlParameter[] sqlParameters = new SqlParameter[] {
                        new SqlParameter("@makhoa",txtMaKhoa.Text),
                        new SqlParameter("@tenkhoa",txtTenKhoa.Text)
                    };
                    if(dataprovider.executeNonQuery(sql, sqlParameters) != -1)
                    {
                        dgvKhoa.DataSource = LoadKhoa();
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Them that bai");
                    }

            }
            txtMaKhoa_Leave(txtMaKhoa, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim().Length > 0)
            {

                string sql = "ps_xoakhoa";
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@makhoa",txtMaKhoa.Text),
                };
                if (dataprovider.executeNonQuery(sql, sqlParameters) != -1)
                {
                    MessageBox.Show("xoa thanh cong");
                    dgvKhoa.DataSource = LoadKhoa();
                }
                else
                {
                    MessageBox.Show("xoa that bai");
                }
            }
            txtMaKhoa_Leave(txtMaKhoa, e);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = " ps_suakhoa";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@makhoa",txtMaKhoa.Text),
                new SqlParameter("@tenkhoa",txtTenKhoa.Text)
            };
            if (dataprovider.executeNonQuery(sql, sqlParameters) != -1)
            {
                MessageBox.Show("sua thanh cong");
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
        }

        private void txtMaKhoa_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (txtMaKhoa.Text.Trim().Length  == 0)
            {
                //errorProvider = new ErrorProvider();
                errorProvider.SetError(control, "Vui long nhap gia tri");
                txtMaKhoa.Focus();
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void quanLiSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }
        private DataTable loadSinhVien()
        {
            string sql = "ps_hiensinhvien";
            return dataprovider.executeQuery(sql);

        }
        private void loadCBKhoa()
        {
            cbKhoa.DataSource = LoadKhoa();
            cbKhoa.DisplayMember = "tenkhoa";
            cbKhoa.ValueMember = "makhoa";
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = loadSinhVien();
            loadCBKhoa();
        }

        private void dgvKhoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKhoa.CurrentRow;
            txtMaKhoa.Text = row.Cells[0].Value.ToString();
            txtTenKhoa.Text = row.Cells[1].Value.ToString();
        }
        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSinhVien.CurrentRow;
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@makhoa",row.Cells[8].Value.ToString().Trim())
            };
            string tenKhoa = dataprovider.ExecuteScalar("ps_getTenKhoa",sqlParameters).ToString();
            cbKhoa.Text = tenKhoa;
        }


    }
}
