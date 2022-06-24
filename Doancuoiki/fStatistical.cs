using Doancuoiki.DAO;
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
    public partial class fStatistical : Form
    {
        public fStatistical()
        {
            InitializeComponent();
        }

        private void fStatistical_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKeImport_Click(object sender, EventArgs e)
        {
            LoadListImport(dtpkImport.Value);
        }

        private void btnThongKeExport_Click(object sender, EventArgs e)
        {
            LoadListExport(dtpkImport.Value, dtpkExport.Value);
        }

        void LoadListImport(DateTime checkIn)
        {
            dtgvStatical.DataSource =  BillDAO.Instance.GetListImport(checkIn);
        }

        void LoadListExport(DateTime checkIn, DateTime checkOut)
        {
            dtgvStatical.DataSource = BillDAO.Instance.GetListExport(checkIn, checkOut);
        }

       
    }
}
