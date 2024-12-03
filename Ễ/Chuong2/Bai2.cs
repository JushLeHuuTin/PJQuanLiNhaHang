    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace Chuong2
    {
        public partial class Bai2 : Form
        {
            public Bai2()
            {
                InitializeComponent();
            }

            private void progressBar1_Click(object sender, EventArgs e)
            {
            
            }

            private async void Bai2_Load(object sender, EventArgs e)
            {

                for (int i = 0; i <= 100; i++)
                {
                    await Task.Delay(150);
                    // Cập nhật giá trị của ProgressBar
                    prbForm1.Value = i;
                }
                new Bai1().Show();
                this.Hide();
            }

            private void btnOk_Click(object sender, EventArgs e)
            {
                 new Bai1().Show();
                this.Close();
            }
        }
    }
