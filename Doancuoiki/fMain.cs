using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancuoiki
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            fStatistical f = new fStatistical();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            fImport f = new fImport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            fExport f = new fExport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            fOrther f = new fOrther();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
