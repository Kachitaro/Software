using Doancuoiki.DAO;
using Doancuoiki.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Doancuoiki
{
    public partial class fOrther : Form
    {
        public fOrther()
        {
            InitializeComponent();
            LoadOrther();
        }


        void LoadOrther()
        {
            flpDonHang.Controls.Clear();
            List<Orther> Ortherlist = OrtherDAO.Instance.LoadOrtherList() ;
            foreach (Orther item in Ortherlist)
            {
                Button btn = new Button() { Width = OrtherDAO.TableWidth,Height = OrtherDAO.TableHeight};
                btn.Text = item.IdCus + Environment.NewLine + item.Status;
                btn.BackColor = Color.Gold;
                btn.Click += Btn_Click;
                btn.Tag = item;
                
                flpDonHang.Controls.Add(btn);
            }

        }

        void showBill(int id)
        {
            lvChiTietDonHang.Items.Clear();
            List<ChiTiet> listBillInfo = ChiTietDAO.Instance.GetChiTietList(id);
            float totalPrice = 0;

            foreach (ChiTiet item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.MatHang.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lvChiTietDonHang.Items.Add(lvItem);
            }
            CultureInfo c = new CultureInfo("vi-VN");
            tbTotalprice.Text = totalPrice.ToString("c",c);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int idOrther = ((sender as Button).Tag as Orther).IdOr;
            lvChiTietDonHang.Tag = (sender as Button).Tag;
            showBill(idOrther);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Orther orther = lvChiTietDonHang.Tag as Orther;

            int idBill = BillDAO.Instance.GetUncheckBillByOrderID(orther.IdOr);

            if (idBill != -1)
            {
                if(MessageBox.Show("Bạn có chắc " + orther.IdCus + " đã thanh toán đơn hàng","Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckExport(idBill);
                    showBill(idBill);
                    LoadOrther();
                }
            }
        }
    }
}
