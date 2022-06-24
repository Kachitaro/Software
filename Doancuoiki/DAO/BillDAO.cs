using Doancuoiki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        { 
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set => instance = value;
        }

        private BillDAO() { }

        public int GetUncheckBillByOrderID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from dbo.Bill where idOrther = "+ id+"and st = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public DataTable GetListImport(DateTime checkIn)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListNhap @dateCheckIn", new object[] { checkIn });
        }

        public DataTable GetListExport(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListNhap @dateCheckIn", new object[] { checkIn, checkOut });
        }

        public void CheckExport(int id)
        {
            string query = "Update dbo.bill SET dateChenkOut = Getdate(), st = 1, tinhTrang =  N'Đang vận chuyển' where id = " + id;
            //DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
