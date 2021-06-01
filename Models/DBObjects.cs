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
                        "Документация",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img19/3747757/11.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img211/3747758/12.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img101/3747759/13.jpg"
                            }
                        }
                    },

                    new Product
                    {
                        Category = Category["POD-системы и комплектующие"],
                        ProductType = TypeProduct.GeekVape,
                        Img = "https://imageup.ru/img94/3746857/2.jpg",
                        Name = "GeekVape Aegis Hero Pod Mod Kit",
                        Value = 2390,
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
                       "Кабель Micro-USB",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img215/3747761/21.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img193/3747763/22.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img176/3747764/23.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["POD-системы и комплектующие"],
                        ProductType = TypeProduct.GeekVape,
                        Img = "https://imageup.ru/img45/3747778/1.jpg",
                        Name = "GeekVape Aegis Boost Pro Pod Mod Kit",
                        Value = 2990,
                        Description = "Обратите внимание на комплект Geek Vape Aegis Boost PRO 100W Pod Mod Kit, " +
                        "с диапазоном мощности 5-100 Вт с для контролем температуры и вмещающий до 6 мл жидкости в картридже. " +
                        "Построенный из прочного цинкового сплава, корпус Geek Vape Aegis Boost Pro поддерживает IP67 по защите от пыли, " +
                        "ударов и водонепроницаемости. В девайсе используется один аккумулятор 18650 (продается отдельно). " +
                        "Кроме того, модуль Aegis Boost Pro Pod Mod может вместить до 6 мл жидкости на классической или солевой никотиновой основе. " +
                        "В сочетании с испарителями Geek Vape P гарантирован отличный вкус и пар.",

                        Characteristics = "Аккумулятор: 18650 (приобретается отдельно)\n" +
                       "Выходная мощность: 5 - 100 Вт\n" +
                       "Объем картриджа: 6 мл" +
                       "Диапазон сопротивления: 0.1 Ω - 3.0 Ω\n" +
                       "Защита IP67\n" +
                       "Вращающийся диск для управления воздушным потоком\n" +
                       "Зарядка: USB Type-C\n" +
                       "Размер: 83x48x25 мм\n" +
                       "Размер: 113x50x29 мм\n",
                        Equipment = "GeekVape Aegis Boost Pro Pod\n" +
                       "Картридж\n" +
                       "Испаритель 0.4 Ω P Mesh Coil (50-60 Вт)\n" +
                       "Испаритель 0.2 Ω P Mesh Coil (60-70 Вт)\n" +
                       "Кабель USB Type-C\n" +
                       "Документация",
                       Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img204/3747779/2.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img193/3747763/22.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img76/3747780/3.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["POD-системы и комплектующие"],
                        ProductType = TypeProduct.SMOK,
                        Img = "https://imageup.ru/img110/3748532/nord2-previu.jpg",
                        Name = "SMOK Nord 2 pod kit",
                        Value = 1990,
                        Description = "Компания SMOK выпустила вторую версию популярной POD-системы - SMOK Nord 2 Pod Kit. Устройство" +
                       "получило большое количество плюшек: поддержка огромного количества картриджей и RBA, Бак с" +
                       "емкостью 4.5 мл, встроенный аккумулятор на 1500mAh, дисплей и регулировка мощности в пределах" +
                       "40 Вт. Кроме того, SMOK Nord 2 Pod Kit 40W немного увеличился в размерах, относительно " +
                       "предшественника, его габариты составляют 95х30х20 и вес 80г.",

                        Characteristics = "Аккумулятор: 1500 mAh\n" +
                       "Выходная мощность: 1 - 40 Вт\n" +
                       "Диапазон сопротивления: 0.3 - 3.0 Ωn" +
                       "Объем картриджа: 4.5 мл\n" +
                       "Дисплей: 0.69' OLED\n" +
                       "Защита от перегрева\n" +
                       "Размер: 95x30x20 мм\n" +
                       "Вес: 80 гр\n",
                        Equipment = "SMOK Nord 2 pod kit\n" +
                       "Картридж на 4.5 мл\n" +
                       "Испаритель 0.4 Ω RPM Mesh\n" +
                       "Испаритель 0.8 Ω Nord DC MTL\n" +
                       "Кабель Micro-USB",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img110/3748532/nord2-previu.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img216/3748533/nord2-2.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img286/3748534/nord-2-3.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["POD-системы и комплектующие"],
                        ProductType = TypeProduct.SMOK,
                        Img = "https://imageup.ru/img239/3748540/rpm1.jpg",
                        Name = "SMOK RPM 2 Pod Kit (СМОК РПМ 2)",
                        Value = 2590,
                        Description = "Известный и любимый многими производитель SMOK продолжает бомбить новинками! Новая" +
                       "подсистема SMOK RPM 2 Pod Kit 80W. Устройство крайне интересное, обладающее емким" +
                       "аккумулятором, солидным запасом мощности и потрясающей вариативностью в плане испарителей." +
                       "SMOK RPM 2 Kit внешне напоминает устройство Nord 2 от того же производителя — СМОК. Но RPM 2" +
                       "достаточно сильно превосходит его по габаритам - 28х31х108,5 мм и при этом весит 132 грамма." +
                       "Материалы корпуса стандартные — металл и пластик." +
                       "SMOK RPM 2 способен выдавать мощность до 80 ватт, плата поддерживает только режим вариватта и" +
                       "способна поднимать намотки с сопротивлением от 0,15 до 3,0 Ом. Затяжка осуществляется путем" +
                       "нажатия на кнопку Fire.",

                        Characteristics = "Аккумулятор: 2000 mAh\n" +
                       "Выходная мощность: 1 - 80 Вт\n" +
                       "Диапазон сопротивления: 0.15 - 3.0 Ωn" +
                       "Объем картриджа: 7 мл\n" +
                       "Дисплей: 1.14' OLED\n" +
                       "Защита от низкого/высокого сопротивления, от перегрева, от кз.\n" +
                       "Размер: 108,5x31x28 мм\n" +
                       "Вес: 132 гр\n",
                        Equipment = "SMOK RPM 2 pod kit\n" +
                       "Картридж 0.4 Ω RPM Mesh\n" +
                       "Картридж 0.16 Ω RPM 2 Mesh\n" +
                       "Кабель USB-C",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img239/3748540/rpm1.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img114/3748541/rpm2.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img23/3748542/rpm3.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["Девайсы"],
                        ProductType = TypeProduct.Аккамуляторы,
                        Img = "https://imageup.ru/img106/3748689/vtc6.jpg",
                        Name = "Sony / Murata VTC6 - 3000mAh, 30A, 3.6V",
                        Value = 550,
                        Description = "Высокотоковые аккумуляторы Sony / Murata VTC6 наиболее часто используется в вариватах и" +
                       "варивольтах, но также может быть использован в механическом моде.",
                       

                        Characteristics = "Типоразмер: 18650\n" +
                       "Модель: US18650VTC6\n" +
                       "Емкость: 3000мАч" +
                       "Напряжение номинальное: 3.6В\n" +
                       "Максимальный ток разряда: 30А\n" +
                       "Максимальный ток заряда: 6А\n",

                        Equipment = "Sony / Murata VTC6\n" +
                       "Сам аккамулятор\n",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img106/3748689/vtc6.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["Девайсы"],
                        ProductType = TypeProduct.Аккамуляторы,
                        Img = "https://imageup.ru/img149/3748690/5a1.jpg",
                        Name = "Sony / Murata VTC5A",
                        Value = 450,
                        Description = "Данный вид аккумуляторов приобрел большую популярность среди владельцев механических модов" +
                       "из-за высокой токоотдачи и надежности, но также может использоваться и боксмодах.",


                        Characteristics = "Типоразмер: 18650\n" +
                       "Модель: US18650VTC5A\n" +
                       "Емкость: 2600мАч" +
                       "Напряжение номинальное: 3.6В\n" +
                       "Максимальный ток разряда: 35А\n" +
                       "Максимальный ток заряда: 6А\n",

                        Equipment = "Sony / Murata VTC5A\n" +
                       "Сам аккамулятор\n",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img149/3748690/5a1.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["Девайсы"],
                        ProductType = TypeProduct.Аккамуляторы,
                        Img = "https://imageup.ru/img289/3748691/40t1.jpg",
                        Name = "Samsung 40T - 4000mAh, 30A, 3.7V",
                        Value = 790,
                        Description = "Данный вид аккумуляторов подходит для всех видов устройств.",


                        Characteristics = "Типоразмер: 21700\n" +
                       "Тип: Li-ion, незащищенный, плюсовой контакт плоский\n" +
                       "Емкость: 4000мАч" +
                       "Напряжение номинальное: 3.7В\n" +
                       "Максимальный ток разряда: 30А\n",

                        Equipment = "Samsung 40T - 4000mAh, 30A, 3.7V\n" +
                       "Сам аккамулятор\n",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img289/3748691/40t1.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["Девайсы"],
                        ProductType = TypeProduct.Готовые_койлы,
                        Img = "https://imageup.ru/img156/3748692/k1.jpg",
                        Name = "Framed Alien - 0.07 Ω (ручная намотка)",
                        Value = 400,
                        Description = "Framed Alien - когда все самое лучшее из двух видов намоток собрано в одной. От Framed Staple -" +
                        "отличная впитываемость и быстрый старт, от Alien - волнистая оплетка, которая отлично раскрывает\n" +
                        "вкус твоих любимых жидкостей. Попробуй и ты будешь в восторге! Framed Alien 0.07 Ω подойдет для\n" +
                        "мехмода и платы от 0.05 Ω. Поставляется в упаковке от Framed Staple.\n",

                        Characteristics = "Сопротивление 0.07 Ω\n" +
                       "Цвет: Градиент\n",

                        Equipment = "Framed Alien - 0.07 Ω (ручная намотка)\n" +
                       "Койлы\n"+
                        "Вата\n",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img156/3748692/k1.jpg"
                            }
                        }
                    },
                    new Product
                    {
                        Category = Category["POD-системы и комплектующие"],
                        ProductType = TypeProduct.Logic_Compact,
                        Img = "https://imageup.ru/img231/3748685/l1.jpg",
                        Name = "Logic Compact Kit",
                        Value = 2590,
                        Description = "Хорошее устройство для парения солевого никотина"+
                        "Идеально подходит для тех, кто хочет быстро накуриться",
                        Characteristics = "Аккумулятор: 500 mAh\n" +
                       "Выходная мощность: 5-7 Вт\n" +
                       "Объем картриджа: 2.5 мл\n" +
                       "Размер: 108,5x31x28 мм\n" +
                       "Вес: 50 гр\n",
                        Equipment = "Logic Compact Kit\n" +
                       "Картридж малина\n" +
                       "Картридж тропический микс\n" +
                       "Кабель зарядки",
                        Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img231/3748685/l1.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img212/3748687/l2.jpg"
                            }
                        }
                    },
                     new Product
                     {
                         Category = Category["Девайсы"],
                         ProductType = TypeProduct.Мехмоды,
                         Img = "https://imageup.ru/img227/3748549/2170mekh1.jpg",
                         Name = "Мехмод Rockvape - Rebel 21700 Purple Cyber Set",
                         Value = 22900,
                         Description = "Хороший Дорогой Мех",
                     

                         Characteristics = "Производитель: Rockvape Mods Co\n" +
                       "Материал - латунь\n" +
                       "Постоянный контакт\n" +
                       "Кнопка с пружиной\n" +
                       "Краска - церакот\n" +
                       "Аккумуляторы - 1 x 21700 (18650 с переходником).\n" +
                       "Характеристики дрипки:\n" +
                       "Материал - латунь\n" +
                       "Версия 1.6\n" +
                       "Посеребряная база\n" +
                       "Титановые болты с анодированием\n",
                         Equipment = "Мехмод Rockvape - Rebel 21700 Purple Cyber Set\n" +
                       "Мехмод\n" +
                       "Коробка\n" +
                       "Упаковка",
                         Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img227/3748549/2170mekh1.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img136/3748550/2170mekh2.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img48/3748551/2170mekh3.jpg"
                            },
                             new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img94/3748552/2170mekh4.jpg"
                            }
                        }
                     },
                     new Product
                     {
                         Category = Category["Девайсы"],
                         ProductType = TypeProduct.Мехмоды,
                         Img = "https://imageup.ru/img110/3748563/21m1.jpg",
                         Name = "Мехмод Rockvape - Swordfish 21700 Black Cerakote Set",
                         Value = 19400,
                         Description = "Очередное творение от Rockvape - Swordfish 21700!" +
                         "Дерзкий, яркий и необычный дизайн, а также удобная боковая кнопка с блокировкой нажатия. Это все," +
                         "что нужно знать о данном девайсе.",

                         Characteristics = "Производитель: Rockvape Mods Co. (Россия))\n" +
                       "Материал - латунь\n" +
                       "Постоянный контакт\n" +
                       "Боковая кнопка с блокировкой нажатия\n" +
                       "Краска - церакот\n" +
                       "Аккумуляторы - 1 x 21700 (18650 с переходником).\n" +
                       "Посадка под атомы - 24-25 мм.\n",
                         Equipment = "Мехмод Rockvape - Swordfish 21700 Black Cerakote Set\n" +
                       "Мехмод Rockvape - Swordfish 21700 Black Cerakote\n" +
                       "Дрипка BRO RDA 1.6 с куполом от Rockvape в цвет мехмода\n" +
                       "Койлы от производителя",
                         Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img110/3748563/21m1.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img155/3748564/21m2.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img220/3748565/21m3.jpg"
                            },
                        }
                     },
                     new Product
                     {
                         Category = Category["Девайсы"],
                         ProductType = TypeProduct.Мехмоды,
                         Img = "https://imageup.ru/img219/3748556/mekhg1.jpg",
                         Name = "Мехмод GodMod - Imperium Gloss Black - Gold",
                         Value = 6500,
                         Description = "Новая версия отличного девайса от ребят из God Mod. К особенностям можно отнести стойкое" +
                         "покрытие, боковую кнопку и удобство держания в руке.",


                         Characteristics = "Производитель - GodMod (Россия)\n" +
                       "Материал - латунь ЛС59-1\n" +
                       "Высота мода в заряженном состоянии - 84 мм\n" +
                       "Максимальный диаметр - 31,5 мм, минимальный - 24,5 мм\n" +
                       "Посадка под 25 мм\n" +
                       "Кнопка - боковая\n" +
                       "Формат акб 21700, 20700 и 18650 (через проставку).\n",
                         Equipment = "Мехмод GodMod - Imperium Gloss Black - Gold\n" +
                       "Мехмод\n" +
                       "Коробка\n" +
                       "Упаковка",
                         Imgs = new List<Product_Img>()
                        {
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img219/3748556/mekhg1.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img250/3748557/mekhg2.jpg"
                            },
                            new Product_Img
                            {
                                ImagesUrl = "https://imageup.ru/img65/3748558/mekhg3.jpg"
                            },
                        }
                     },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Солевые_жидкости,
                        Img = "https://imageup.ru/img221/3746858/3.jpg",
                        Name = "Bad Drip Salt - Farley's Gnarly Sauce 30 мл",
                        Value = 850,
                        Description = "Легендарный микс сладкой жвачки с сочным киви и спелой клубники. Вкус, не требующий ни чьих советов и рекомендаций - это всем хорошо известный Фарлик, детка :) " +
                        "Только не говори, что ты его еще не пробовал!",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Солевые_жидкости,
                        Img = "https://imageup.ru/img131/3747740/1.jpg",
                        Name = "Bad Drip Salt - Don’t Care Bear 30 мл",
                        Value = 850,
                        Description = "Вкус мармеладных мишек в сочетании с фруктовым миксом из дынной дыни, грушевой груши и персикового персика.",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Солевые_жидкости,
                        Img = "https://imageup.ru/img233/3747741/2.jpg",
                        Name = "Bad Drip Salt - Cereal Trip 30 мл",
                        Value = 850,
                        Description = "Свежий пончик со сладкой глазурью, усыпанный фруктовыми рисовыми колечками.",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Солевые_жидкости,
                        Img = "https://imageup.ru/img54/3747742/4.jpg",
                        Name = "Maxwells Salt - Rich Waterberry v2 30 мл",
                        Value = 450,
                        Description = "Легендарный жидкость теперь и солевым никотином. Оригинальное сочетание ароматной дыни, " +
                        "сочного арбуза и сладкого клубничного джема, которое не оставит равнодушным любителей фруктовых миксов. ",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Солевые_жидкости,
                        Img = "https://imageup.ru/img185/3747744/5.jpg",
                        Name = "Maxwells Salt - Тундра 30 мл",
                        Value = 450,
                        Description = "Хвойный можжевельник, сладкая мята и кисленькая рябина.",
                    },

                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Щелочные_жидкости,
                        Img = "https://imageup.ru/img17/3747746/2.jpg",
                        Name = "Smoke Kitchen Jam Pod - Virginia Tobacco 30 мл",
                        Value = 240,
                        Description = "Классическая табачка.",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Щелочные_жидкости,
                        Img = "https://imageup.ru/img90/3747747/3.jpg",
                        Name = "Smoke Kitchen Jam Pod - Grape 30 мл",
                        Value = 240,
                        Description = "Спелый виноград с медовыми нотками.",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Щелочные_жидкости,
                        Img = "https://imageup.ru/img231/3747748/4.jpg",
                        Name = "Tobacco Monster Pod - Menthol 30 мл x 2",
                        Value = 850,
                        Description = "Ароматная табачка с ментолом",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Щелочные_жидкости,
                        Img = "https://imageup.ru/img14/3747750/5.jpg",
                        Name = "No Salt Classic - Watermelon Strawberry 30 мл",
                        Value = 420,
                        Description = "Микс клубники и арбуза",
                    },
                    new Product
                    {
                        Category = Category["Жидкости для POD и MTL"],
                        ProductType = TypeProduct.Щелочные_жидкости,
                        Img = "https://imageup.ru/img82/3747745/1.jpg",
                        Name = "Tobacco Monster Pod - Smooth 30 мл x 2",
                        Value = 850,
                        Description = "Ароматная табачка с десертом Испанский крем",
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
                        new Category { Category_Name = "Девайсы" }

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
