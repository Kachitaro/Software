using Doancuoiki.DAO;
using Doancuoiki.DTO;
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
    public partial class fExport : Form
    {
        public fExport()
        {
            InitializeComponent();
            LoadPhieuXuat();
            UpdateStatus();
        }

        void LoadPhieuXuat()
        {
            string query = "select b.dateChenkOut as N'Ngày Xuất', c.Name as N'Tên khách hàng', b.idOrther as N'Mã Đơn', b.tinhTrang as 'Status' from dbo.Bill as b, dbo.Customs as c,dbo.orther as o Where b.st = 1 and o.idOrther = b.idOrther and o.idCus = c.idCus and b.tinhTrang = N'Đang vận chuyển'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dtgvPhieuXuat.DataSource = data;
        }

        void UpdateStatus()
        {
            tbCheckOut.DataBindings.Add(new Binding("Text", dtgvPhieuXuat.DataSource, "Ngày Xuất"));
            tbName.DataBindings.Add(new Binding("Text", dtgvPhieuXuat.DataSource, "Tên khách hàng"));
            tbIdOrther.DataBindings.Add(new Binding("Text", dtgvPhieuXuat.DataSource, "Mã Đơn"));
            tbMove.DataBindings.Add(new Binding("Text", dtgvPhieuXuat.DataSource, "Status"));
        }

        private void btnUMove_Click(object sender, EventArgs e)
        {
            string id = tbIdOrther.Text;
            int MaDon = int.Parse(id);
            DataProvider.Instance.ExecuteNonQuery("Update dbo.bill Set tinhTrang = N'Đã nhận hàng' where idOrther =  " + MaDon);
            LoadPhieuXuat();
        }
    }
}
