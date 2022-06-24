using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DTO
{
    public class BillInfo
    {
        private int iD;
        private int iDBill;
        private int iDMatHang;
        private int count;

        public BillInfo(int iD, int iDBill, int iDMatHang, int count)
        {
            this.ID = iD;
            this.IDBill = iDBill;
            this.IDMatHang = iDMatHang;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idBill"];
            this.IDMatHang = (int)row["idMatHang"];
            this.Count = (int)row["count"];
        }

        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDMatHang { get => iDMatHang; set => iDMatHang = value; }
        public int Count { get => count; set => count = value; }
    }
}
