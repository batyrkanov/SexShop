using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop.Products
{
    class Aphrodisiacs : Product
    {
        // состав
        public string Composition { get; set; }

        public Aphrodisiacs(string name, int price, string manufacturer, string composition)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Composition = composition;
        }

        // переопределенный метод скидок специально для афродизиаков
        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
    }
}
