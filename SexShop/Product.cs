using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    // общий класс товаров
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

        // метод для высчитываения скидки (может быть переопределён в дочерних классах)
        public virtual double GetDiscountPrice(User user)
        {
            if(user.Spent < 300)
            {
                return Price;
            }

            if(user.Spent < 1000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
        }

    }
}
