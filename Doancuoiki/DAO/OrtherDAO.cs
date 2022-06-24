using Doancuoiki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DAO
{
    public class OrtherDAO
    {
        private static OrtherDAO instance;

        public static OrtherDAO Instance 
        {
            get { if (instance == null) instance = new OrtherDAO(); return OrtherDAO.instance; } 
            private set => instance = value; 
        }

        public static int TableWidth = 750;
        public static int TableHeight = 50;
        private OrtherDAO() { }

        public List<Orther> LoadOrtherList()
        {
            List<Orther> Ortherlist = new List<Orther>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetOrtherList");

            foreach (DataRow item in data.Rows)
            {
                Orther orther = new Orther(item);
                Ortherlist.Add(orther);
            }

            return Ortherlist;

        }
    }
}
