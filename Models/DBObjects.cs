using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Models
{
    public class DBObjects
    {
        public static void Initial(MvcVapeShopContext content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Category.Select(c => c.Value));

            if (!content.Products.Any())
            {
                content.AddRange(

                    new Product
                    {
                        Category = Category["POD-системы и комплектующие"],
                        ProductType = TypeProduct.GeekVape,
                        Name = "GeekVape Aegis Pod Kit",
                        Value = 1850,
                        Score = 3,
                        Img = "https://imageup.ru/img250/3746856/1.jpg",
                        Description = "Откройте для себя систему Geek Vape Aegis Pod с надежной степенью защиты IP67, " +
                        "многоразовым картриджем объемом 3,5 мл и встроенной аккумуляторной батареей емкостью 800 мАч. " +
                        "Aegis Pod Kit изготовлен из прочного цинкового сплава, использует прошитую кожу для роскошного ощущения. " +
                        "Обладая степенью защиты IP67, комплект Geek Vape Aegis Pod Kit может обеспечить защиту от воды, пыли и ударов от падений. " +
                        "Geek Vape Aegis Pod, содержащий перезаряжаемую батарею емкостью 800 мАч, может обеспечить достаточную мощность благодаря " +
                        "автоматической интеллектуальной настройке мощности. Вмещая до 3,5 мл в картридже, система Geek Vape Aegis Pod System может " +
                        "доставлять пар из вашей любимой жидкости на классическом или солевом никотине в течение дня, облегчая подзарядку через порт USB Type-C.",
                        Characteristics = "Аккумулятор: 800 mAh\n" +
                        "Выходная мощность: 12 - 18 Вт\n" +
                        "Диапазон сопротивления: 0.4 - 3.0 Ω\n" +
                        "Объем картриджа: 3.5 мл\n" +
                        "Зарядка: USB Type-C\n" +
                        "Защита: от низкого заряда батареи, от короткого замыкания, от перегрева, тайм-аут 10 сек\n" +
                        "Размер: 88x40x18 мм",
                        Equipment = "GeekVape Aegis Pod\n" +
                        "Картридж на 3.5 мn\n" +
                        "Кабель USB Type-C\n" +
                        "Документация"
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Солевые_жидкости,
                        Img = "https://imageup.ru/img221/3746858/3.jpg",
                        Name = "Bad Drip Salt - Farley's Gnarly Sauce 30 мл",
                        Value = 850,
                        Score = 3,
                        Description = "Легендарный микс сладкой жвачки с сочным киви и спелой клубники. Вкус, не требующий ни чьих советов и рекомендаций - это всем хорошо известный Фарлик, детка :) " +
                        "Только не говори, что ты его еще не пробовал!",
                    },
                    new Product
                    {
                        Category = Category["POD-системы и комплектующие"],
                        ProductType = TypeProduct.GeekVape,
                        Img = "https://imageup.ru/img94/3746857/2.jpg",
                        Name = "GeekVape Aegis Hero Pod Mod Kit",
                        Value = 2390,
                        Score = 2,
                        Description = "Aegis Hero Pod – новейший товар производства GeekVape. Новинка успешно продолжила популярную линейку," +
                       " за счет того, что она теперь существенно меньше и гораздо практичнее." +
                       " Но при этом все еще остается удобной и не лишенной своего стиля. Конструкция сделана из цинкового сплава." +
                       " Благодаря чему ему не страшны мелкие повреждения или падения с небольшой высоты. Силиконовые вставки и " +
                       "элементы из комбинированной кожи позволяют прочно удерживать девайс в руке, без риска выскальзывания. " +
                       "Водонепроницаем и соответствует всем установленным стандартам качества." +
                       "Функциональность Aegis Hero Pod небольшая. Помимо VW имеется обновление счетчика затяжек, " +
                       "блокировка и выбор одного из двух режимов – мощности и байпаса. Для блокировки устройства или" +
                       "снятия блока нужно одновременно нажать клавиши вверх и вниз. Остальные действия выполняются посредством клавиши FIRE – три нажатия необходимы для переключения режимов, " +
                       "а нажатие и удержание позволяет обновить счетчик затяжек.",

                        Characteristics = "Аккумулятор: 1200 mAh\n" +
                       "Выходная мощность: 5 - 45 Вт\n" +
                       "Диапазон сопротивления: 0.1 - 3.0 Ωn" +
                       "Объем картриджа: 4 мл\n" +
                       "IP67\n" +
                       "Дисплей: 0.42' OLED\n" +
                       "Защита от перегрева\n" +
                       "Размер: 83x48x25 мм\n" +
                       "Вес: 88 гр\n",
                        Equipment = "GeekVape Aegis Hero Pod\n" +
                       "Картридж на 4 мл\n" +
                       "Испаритель 0.4 Ω G-series (25-33 Вт)\n" +
                       "Испаритель 0.6 Ω G-series (15-25 Вт)\n" +
                       "510 Дриптип\n" +
                       "Кабель Micro-USB"
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Category
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Category_Name = "POD-системы и комплектующие" },
                        new Category { Category_Name = "Жидкости для POD и MTL" },
                        new Category { Category_Name = "Девайсы" },
                        new Category { Category_Name = "Аккамуляторы" },
                        new Category { Category_Name = "Готовые койлы" }

                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category St in list)
                    {
                        category.Add(St.Category_Name, St);
                    }
                }
                return category;
            }
        }

    }
}
