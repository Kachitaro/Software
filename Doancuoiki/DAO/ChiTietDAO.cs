using Doancuoiki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DAO
{
    public class ChiTietDAO
    {
        private static ChiTietDAO instance;
        private ChiTietDAO() { }

        public static ChiTietDAO Instance 
        {
            get { if (instance == null) instance = new ChiTietDAO(); return ChiTietDAO.instance; } 
            private set => instance = value; 
        }

        public List<ChiTiet> GetChiTietList(int id)
        {
            List<ChiTiet> listChiTiet = new List<ChiTiet>();

            string query = "select h.name,bi.count,h.price,h.price*bi.count as totalPrice from dbo.billInfo as bi, dbo.Bill as b, dbo.mathang as h Where bi.idBill = b.id and bi.idMatHang = h.id and b.st = 0  and b.idOrther = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                ChiTiet ct = new ChiTiet(item);
                listChiTiet.Add(ct);
            }

            return listChiTiet;
        }
    }
}
