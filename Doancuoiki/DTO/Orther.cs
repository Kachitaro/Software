using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DTO
{
    public class Orther
    {
        public Orther (int idOr, string idCus , string status)
        {
            this.IdOr = idOr;
            this.IdCus = idCus;
            this.Status = status;
        }

        public Orther(DataRow row)
        {
            this.IdOr = (int)row["idOrther"];
            this.IdCus = row["name"].ToString();
            this.Status = row["Std"].ToString();
        }

        private string status;
        private string idCus;
        private int idOr;

        public int IdOr { get => idOr; set => idOr = value; }
        
        public string IdCus { get => idCus; set => idCus = value; }
        
        public string Status { get => status; set => status = value; }
    }
}
