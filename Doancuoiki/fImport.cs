using ClosedXML.Excel;
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
    public partial class fImport : Form
    {
        public fImport()
        {
            InitializeComponent();
            LoadCategory();
            LoadPhieuNhap();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "name";
        }

        void LoadMatHangListByCategoryId(int id)
        {
            List<MatHang> listMatHang = MatHangDAO.Instance.GetMatHangByCategoryID(id);
            cbbMatHang.DataSource = listMatHang;
            cbbMatHang.DisplayMember = "name";
        }

        void LoadPhieuNhap()
        {
            string query = "select dbo.mathangCategory.name as 'Danh mục', dbo.mathang.name as 'mặt hàng',dbo.phieuNhap.count as 'số lượng',dbo.phieuNhap.price as 'giá nhập',dbo.phieuNhap.dateCheckIn as 'ngày nhập' from dbo.mathang,dbo.mathangCategory,dbo.phieuNhap where dbo.mathangCategory.id = dbo.phieuNhap.idCategory and dbo.mathang.id = dbo.phieuNhap.idMatHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dtgvPhieuNhap.DataSource = data;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadMatHangListByCategoryId(id);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int idCategory = (cbbCategory.SelectedItem as Category).Id;
            int idMatHang = (cbbMatHang.SelectedItem as MatHang).Id;
            int count = (int)nmUD.Value;
            int price = Convert.ToInt32(txtPriceImport.Text.ToString());

            DataProvider.Instance.ExecuteNonQuery("USP_InsertPhieuNhap @idCategory , @idMatHang , @count , @price ",new object[] { idCategory, idMatHang, count, price });
            LoadPhieuNhap();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
           
        }
    }
}
