using SexShop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SexShop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // создаём пользователя
            User user = new User(
                "Nursultan",
                "Sovetskaya 4",
                1000000,
                550
                );
            Console.WriteLine("Список товаров: ");

            //создаём товар
            Dolls gusDolls = new Dolls(
                "Гусь",
                700,
                "Куклы для взрослых",
                "Резина"
                );

            // выводим информацию о товаре

            Console.WriteLine("Кукла:");
            Console.WriteLine("Название: " + gusDolls.Name);
            Console.WriteLine("Производитель: " + gusDolls.Manufacturer);
            Console.WriteLine("Материал: " + gusDolls.Material);
            Console.WriteLine("Цена: " + gusDolls.Price);
            Console.WriteLine(new String('-', 25));

            //создаём товар
            Condoms DirtyJoes = new Condoms(
                "Глязный Джо",
                490,
                "DUREX",
                18
                );
            // выводим информацию о товаре

            Console.WriteLine("Контрацептив:");
            Console.WriteLine("Название: " + DirtyJoes.Name);
            Console.WriteLine("Производитель: " + DirtyJoes.Manufacturer);
            Console.WriteLine("Размер: " + DirtyJoes.Size);
            Console.WriteLine("Цена: " + DirtyJoes.Price);
            Console.WriteLine(new String('-', 25));

            //создаём товар
            Aphrodisiacs HorsesAphrodosiacs = new Aphrodisiacs(
                "Конский возбудитель",
                900,
                "Ферма у Джо",
                "Любовь"
               
                );
            // выводим информацию о товаре

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + HorsesAphrodosiacs.Name);
            Console.WriteLine("Производитель: " + HorsesAphrodosiacs.Manufacturer);
            Console.WriteLine("Состав: " + HorsesAphrodosiacs.Composition);
            Console.WriteLine("Цена: " + HorsesAphrodosiacs.Price);
            Console.WriteLine(new String('-', 25));

            //создаём товар
            Aphrodisiacs HowToMeetLadyes = new Aphrodisiacs(
                "Мачо",
                1300,
                "Кремниевая долина",
                "Навыки программирования"

                );
            // выводим информацию о товаре

            Console.WriteLine("Афродизиак:");
            Console.WriteLine("Название: " + HowToMeetLadyes.Name);
            Console.WriteLine("Производитель: " + HowToMeetLadyes.Manufacturer);
            Console.WriteLine("Состав: " + HowToMeetLadyes.Composition);
            Console.WriteLine("Цена: " + HowToMeetLadyes.Price);
            Console.WriteLine(new String('-', 25));

            // создаём массив для использования общего интерфейса для каждого объекта классов
            Product[] products = new Product[]
            {
                gusDolls,
                DirtyJoes,
                HorsesAphrodosiacs,
                HowToMeetLadyes
            };


            Informer informer = new Informer();

            //работа программы
            while (true)
            {
                //здороваемся
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                //выводим короткое превью товаров и его порядковый номер {i}
                for(int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберите товар и нажмите ENTER: ");

                //считываем введенную строку и конвертируем в числовой тип
                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                //проверяем, находится ли наш товар в массиве продуктов
                if(productNumber >= 0 && productNumber < products.Length)
                {
                    //проверяем стоимость товара и баланс пользователя
                    if(products[productNumber].Price < user.Balance)
                    {
                        //если всё ок, то извещаем об успешной покупке
                        informer.Buy(user, products[productNumber]);
                    }

                    else
                    {
                        // иначе выводим сообщение 
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                else
                {
                    //если введенное число не соответствует имеющимся, выводим ошибку
                    Console.WriteLine("Таких товаров нет");
                }




            }
        }
    }
}
