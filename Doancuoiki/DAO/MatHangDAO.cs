using Doancuoiki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DAO
{
    public class MatHangDAO
    {
        private static MatHangDAO instance;

        public static MatHangDAO Instance
        {
            get { if (instance == null) instance = new MatHangDAO(); return MatHangDAO.instance; }
            private set => instance = value;
        }

        private MatHangDAO() { }

        public List<MatHang> GetMatHangByCategoryID(int id)
        {
            List<MatHang> list = new List<MatHang>();

            string query = "select * from mathang where idCategory = "+ id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item  in data.Rows)
            {
                MatHang matHang = new MatHang(item);
                list.Add(matHang);
            }

            return list;
        }
    }
}
