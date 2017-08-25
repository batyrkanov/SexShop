using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop.Products
{
    class Dolls : Product
    {
        public string Material { get; set; }

        public Dolls(string name, int price, string manufacturer, string material)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Material = material;
        }
    }
}
