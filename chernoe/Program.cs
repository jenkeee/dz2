using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chernoe
{
    class Program
    {
        static void Main(string[] args)
        {
                            Console.Title = ("5. Рассчитать и вывести индекс массы тела(ИМТ).");
                double weight, high;
                Console.WriteLine("Привет, я программа которая считает ИМТ, давай посчитаем индекс массы тела и посмотрим что же он значит. ");
                Console.Write("Введите ваш вес в кг: ");
                weight = Convert.ToDouble(Console.ReadLine());
                /*
                 * weight += Math.Round(weight, 1, MidpointRounding.AwayFromZero);
                Console.WriteLine($"я округлил переменную weight = {weight} до toEven, эксперементирую дальше");
                */
                //if (weight != double)
                { }
                Console.Write("Введите ваш рост в см: ");
                high = Convert.ToInt32(Console.ReadLine());
                double I = weight / (Math.Pow(high / 100, 2));// weight / (high/100 * high/100);  // (Math.Pow(x / y, 2)) - возводит в степень 2 // Math.Sqrt извлекает квадрат
                Console.WriteLine("I = {0:f4}", I);
                /*
                 ИМТ < 18.5: 	Ниже нормального веса
            ИМТ >= 18.5 И < 25: 	Нормальный вес
            ИМТ >= 25 И < 30: 	Избыточный вес
    ИМТ >= 30 И < 35: 	Ожирение I степени
    ИМТ >= 35 И < 40: 	Ожирение II степени
    ИМТ >= 40: 	Ожирение III степени
                */
                double i_id;
                double i_id_up;
                double we_1;
                double we_2;

                if (I < 18.5)
                {
                    Console.WriteLine("Ниже нормального веса");
                    i_id = 18.5 - I; // i_id разница между желаемым минимум и фактическим значением
                    i_id_up = 25 - I; //i_id_up разница между желаемым максимумом и фактическим значением
                    we_1 = i_id * (Math.Pow(high / 100, 2)); // we_1 это вес который необходимо добавить до порого идеального минимума
                    we_2 = i_id_up * (Math.Pow(high / 100, 2)); // we_2 это вес который необходимо добавить до порого идеального максимума
                Console.WriteLine("Вам стоит набрать минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);

                }
                else if (I >= 18.5 && I < 25) { Console.WriteLine("Нормальный вес"); }
                else if (I >= 25 && I < 30)
                {
                    Console.WriteLine("Избыточный вес");
                i_id = 25 - I; 
                i_id_up = 18.5 - I;
                we_1 = i_id * (Math.Pow(high / 100, 2));
                    we_2 = i_id_up * (Math.Pow(high / 100, 2));
                we_1 = -we_1;
                we_2 = -we_2;
                    Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
                }
                else if (I >= 30 && I < 35)
                {
                    Console.WriteLine("Ожирение I степени");
                i_id = 25 - I;
                i_id_up = 18.5 - I;
                we_1 = i_id * (Math.Pow(high / 100, 2));
                    we_2 = i_id_up * (Math.Pow(high / 100, 2));
                we_1 = -we_1;
                we_2 = -we_2;
                Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
                }
                else if (I >= 35 && I < 40)
                {
                    Console.WriteLine("Ожирение II степени");
                i_id = 25 - I;
                i_id_up = 18.5 - I;
                we_1 = i_id * (Math.Pow(high / 100, 2));
                    we_2 = i_id_up * (Math.Pow(high / 100, 2));
                we_1 = -we_1;
                we_2 = -we_2;
                Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
                }
                else if (I >= 40)
                {
                    Console.WriteLine("Ожирение III степени");
                i_id = 25 - I;
                i_id_up = 18.5 - I;
                we_1 = i_id * (Math.Pow(high / 100, 2));
                    we_2 = i_id_up * (Math.Pow(high / 100, 2));
                we_1 = -we_1;
                we_2 = -we_2;
                Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
                }
                else { Console.WriteLine("неведомая хуйня"); }

            Console.ReadKey();
            }

        }
    }

