using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DTO
{
    public class ChiTiet
    {
        public ChiTiet (string matHang, int count , float price , float totalPrice = 0)
        {
            this.MatHang = matHang;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public ChiTiet(DataRow row)
        {
            this.MatHang = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private string matHang;
        private int count;
        private float price;
        private float totalPrice;


        public string MatHang { get => matHang; set => matHang = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
