using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarSolution
{
    public class Product
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string DepartmentName { get; set; }

        public Product(string Name, int Quantity, double Price, string DepartmentName)
        {
           // this.Id = Id;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
            this.DepartmentName = DepartmentName;
        }

        public string[] GetDetails()
        {
            string[] details = new string[3];
            details[0] = Quantity.ToString();
            details[1] = Price.ToString();
            return details;
          
        }
    }
}
