using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiki.DTO
{
    public class MatHang
    {
        private int id;
        private string name;
        private int categoryID;
        private float price; 
        public MatHang(int id,string name, int category, float prire)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryID = category;
            this.Price = prire;
        }
        public MatHang(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
    }
}
