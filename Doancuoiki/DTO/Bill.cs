using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int iDOrther;
        private int st;

        public Bill(int id,DateTime? dateCheckIn,DateTime? dateCheckOut, int iDOrther, int st)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.IDOrther = iDOrther;
            this.St = st;
        }

        public Bill(DataRow row)
        {
            this.ID= (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"] ;

            var dateCheckOutTemp = row["dateChenkOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.IDOrther = (int)row["idOrther"] ;
            this.St = (int)row["st"] ;
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int IDOrther { get => iDOrther; set => iDOrther = value; }
        public int St { get => st; set => st = value; }
    }
}
