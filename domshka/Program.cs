using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domshka
{
    class Program
    {      

            /*
             * если просит ввести цифру надо ввести цифру , иначе будет краш. буду думать в сторону while
             * 
             * главное 3тье задание запони навсегда
             */
            #region menu 
            /// <summary>
            /// точка входа в программу Main
            /// </summary>
            /// <param name="args"> параметры входа</param>
            static void Main(string[] inthis)  // inthis в данном случае имя метода может быть любым 
            {
                // int x; // просто объявил переменную и не стал присаивать ей 0 как было раньше
                var b = true;
                string first_name = "dart";
                string last_name = "vaider";
                int x = 0;
                do
                {
                    Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите номер задачи 1-5, прочие символы не нравятся приложению, ??? ");
                    x = Convert.ToInt32(Console.ReadLine());     // если программе сообщить пробел, или символ то она даст ошибку, 
                                                                 //if (x) { string; break; } // вобще не туда думаю но вопрос пока оставим
                    Console.Title = ("Меню");
                    switch (x)
                    {
                        case 1:
                            pr1();
                            break;
                        case 2:
                            pr2();
                            break;
                        case 3:
                            pr3();
                            break;
                        case 4:
                            dz4();
                            break;
                        case 5:
                            dz5(first_name, last_name);
                            break;
                        case 6:
                            dz6();
                            break;
                        case 7:
                            bonus();
                            break;
                    
                    default:      // понравилась эта констуркция, не совсем понятно но понятно как использовать и редактировать , все дз буду оформлять по этому типу
                                      // думаю как сделать проверку на X при чем тут не равно b  // как я понял        // b = !b; вобще не понятно зачем тут это   // переворачиваем true в false           
                            Console.Write("пока пока");
                            b = !b; // !b - в данном случае возращает false вместо true, перезаписываем переменную b // while работает
                                    // b = true; // вернул b - значение true в таком случае while не будет не будет использованно

                            /* тут смысл сбить значение b если выполнен default чтобы удовлетворить while , в нашем случае не удовлетворить*/

                            break;
                    }
                    Console.ReadKey();
                } while (b); // Вобще этот while если мы все. закончили программу. надо сообщить ему лож и он будет выполнен false = true ^ true
                Console.WriteLine(true ^ true);
                Console.Clear();
                Console.SetCursorPosition(10, 15);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("THE FORCE BE WITH U... SEE YA LATER");
                Console.WriteLine("Пытаюсь понять while исключения ");
                Console.ReadKey();
            }
        #endregion
        #region задание 1
        /// <summary>
        /// 1. Написать метод, возвращающий минимальное из трёх чисел.
        /// </summary>
        static void pr1()
            {
            // не совсем понимаю зачем, но по условию задачи я должен сделать вывод методом еще наделаю переменных a g c
            int min(int a, int g, int c)
            {
                int minimal;

                if (a < g && a < c)
                {
                    minimal = a;
                }
                else if (g < a && g < c)
                {
                    minimal = g;

                }
                else if (c < a && c < g)
                {
                    minimal = c;

                }
                else { Console.WriteLine("2 самых меньших числа или все меньшие. Прошу вводи разные числа, ну или 3 меньших числа, ну бывай"); minimal = c; }

                return minimal;
            }
            // собственно я закончил метод 
            var b = true;
            Console.Title = ("1. Написать метод, возвращающий минимальное из трёх чисел.");
            Console.Clear();
            Console.WriteLine("Привет, сейчас я попрошу ввести тебя ввести 3 числа и я выберу самое меньшее.");
            Console.Write("Введи первое число.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи второе число.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи 3-е число.");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Минимальное число: { min(x, y, z)} вот и представь, создал метод , оно стоило того в данном случае?");
            
            if (x < y && x < z)
            {
                Console.WriteLine("Самое меньшее число " + x);
            }
            else if (y < x && y < z)
            {
                Console.WriteLine("Самое меньшее число " + y);

            }
            else if (z < y && z < x)
            {
                Console.WriteLine("Самое меньшее число " + z);

            }
            else { Console.WriteLine("2 самых меньших числа или все меньшие. Прошу вводи разные числа" ); }
            while (x == 0 && y == 0 && z == 0)
            {

                Console.Clear();
                Console.SetCursorPosition(10, 15);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("THE FORCE BE WITH U... SEE YA LATER");
                Console.WriteLine("Ты указал 3 нуля. и завис тут потому что я написал while вместо else if , while надо писать если ты планируешь выполнять повторяемое вычесление до тех пор пока условие не нарушится");


                
                Console.ReadKey();


            }

        }

        #endregion
        #region задание 2
        /// <summary>
        /// 2. Написать метод подсчета количества цифр числа.
        /// </summary>
        /// 

        static void pr2()
            {
            Console.Title = ("2. Написать метод подсчета количества цифр числа.");
            Console.Write("Число: ");
            Console.WriteLine("Количество знаков: " + count(Console.ReadLine()));
            Console.ReadKey();
        }
        static int count(string s) // создал статический метод int типа который вернет s.length // понять бы откуда берется s - s получает значение readkey почему?
        {
            return s.Length; // возвращает длину s 
        }

        #endregion
        #region задание 3
        /// <summary>
        /// 3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

        /// </summary>
        static void pr3()
            {
            Console.Title = ("3.	С клавиатуры вводятся числа, пока не будет введен 0. ");
            double score = 0;
            double input = 0;
            double into = 0;
            bool flag = false;


            while (true) // Вечный цикл
            {
                while (!flag)
                {
                    Console.Clear(); // Чистим консоль.
                    Console.WriteLine($"Сумма всех чисел = {score}"); // Вывод суммы чисел.
                    Console.Write("Повторите ввод числа: "); // Вывод сообщения.

                    flag = double.TryParse(Console.ReadLine(), out input); // Защита от дурака // try parse то что я искал // out input записывает в input
                    if (input > 0 && input % 2 == 1) // делаем условие проверка на нечет и положительное
                        into = input; // если условие выполнено, записываем введенное число, дальше мы его сложим
                    else
                        into = 0; // условие не выполнено, даем введенному значению 0
                }

                flag = false; // Избавляемся от бага. // запомни это 
                score = score + into; // Прибавляем к сумме чисел новое число прошедшее условие проверки на + и нечет

                if (input == 0) break; // Выход из вечного цикла:
            }

            Console.Clear(); // Чистим консоль.
            Console.WriteLine($"Итоговая сумма всех чисел: {score}"); // Вывод итоговой суммы чисел.
            Console.ReadKey(); // Ждём нажатие клавиши.
        }

        #endregion
        #region задание 4
        /// <summary>
        /// 4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
        /// (Логин: root, Password: GeekBrains). 
        /// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
        /// программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

        /// </summary>
        static void dz4() // с тобой не закончили
            {
            Console.Title = ("4.	Реализовать метод проверки логина и пароля.");
            Console.Write("Введите логин: ");
            string u_name = Console.ReadLine(); // запоминаем логин в юнейм
            Console.Write("Введите пароль: ");
            string u_pass = Console.ReadLine(); // запоминаем пароль в юпасс
            int counter = 2; // количество попыток



            do
            {
                Console.Clear(); // Чистка консоли

                if (val_user(u_name) == false)  // Проверка логина и пароля причем проверяет логин, а пароль уже проверяется в методе логина вызовом заранее созданого метода, мне интиресно
                                                // насколько важно описывать методы вызываемые в главном до главного метода, я их описываю после.
                {
                    if (counter <= 0) // счетчик попыток
                    {
                        Console.SetCursorPosition(13, 10);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("ТЫ ИСЧЕРПАЛ ПОПЫТКИ!");
                        Console.SetCursorPosition(10, 15);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("THE FORCE BE WITH U... SEE YA LATER");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("логин root был");
                        break; // выход из цикла // ++++
                    }
                    else
                    {
                        Console.WriteLine($"Я в тебя верю, у тебя осталось попыток : {counter}"); // покажет сколько попыток осталось 
                        counter = counter - 1; // операция инкремента
                        Console.SetCursorPosition(10, 15);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("THE FORCE BE WITH U... SEE YA LATER");
                        Console.SetCursorPosition(10, 16);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR!"); // Вывод ошибки
                        Console.SetCursorPosition(10, 3);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Введите логин: ");
                        u_name = Console.ReadLine(); // Вводим логин

                        Console.Write("Введите пароль: ");
                        u_pass = Console.ReadLine(); // Вводим пароль
                        
                    }
                }

                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 15);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("THE FORCE BE WITH U... SEE YA LATER");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(10, 16);
                    Console.WriteLine("YOU ARE WELCOME PREPERE TO FIGHT!!!!!");
                    break; // выход из цикла
                }

            } while (true); // вечный цикл


            bool val_user(string user)
            {
                if (user == "root")
                {
                    if (val_pass(u_pass) == true) // Проверяем пароль методом val_pass();
                    {
                        Console.WriteLine("Пароль правильный!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Пароль не правильный!");
                        return false;
                    }
                }
                else return false; // user не совпал
                Console.WriteLine("Пользователь найден!");
                

            }
            bool val_pass(string password) 
            {
                if (password == "GeekBrains")
                {
                    return true; // пароль совпал
                }
                else return false; // пароль не совпал
            }

        }

        #endregion
        #region задание 5
        /// <summary>
        //        5.
        //        а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //        б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            /// </summary>

            static void dz5(string first_name, string last_name)
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
            double we_1 ;
            if (I < 18.5) { 
                Console.WriteLine("Ниже нормального веса");
                 i_id = 18.5 - I;
                we_1= i_id * (Math.Pow(high / 100, 2));
                Console.WriteLine("Вам стоит набрать минимум " + we_1 + " кг для нормального веста. ");
              
            }
            else if (I >= 18.5 && I < 25 ) { Console.WriteLine("Нормальный вес"); }
            else if (I >= 25 && I < 30) { Console.WriteLine("Избыточный вес"); }
            else if (I >= 30 && I < 35) { Console.WriteLine("Ожирение I степени"); }
            else if (I >= 35 && I < 40) { Console.WriteLine("Ожирение II степени"); }
            else if (I >= 40 ) { Console.WriteLine("Ожирение II степени"); }
            else { Console.WriteLine("неведомая хуйня"); }


        }

            /// <summary>
            /// вот и задание под В, ну или я не правильно понял, создаю метод about
            /// </summary>
            static void about(string ms, int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(ms);
                //return first_name;
            }
            #endregion
            #region 6 задание
            /// <summary>
            /// 6)  *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
            /// </summary>
            static void dz6()
            {
                DateTime start = DateTime.Now;
                int k = 0;
                for (int i = 2; i < 1000000; i++)
                    if (IsSimple(i))
                    {
                        k++;
                        Console.WriteLine("{0} {1}", k, i);
                    }
                Console.WriteLine(k);
                Console.WriteLine(DateTime.Now - start);

            }
            static bool IsSimple(int n)
            {
                for (int i = 2; i <= n / 2; i++)
                    if (n % i == 0) return false;
                return true;
            }
            #endregion
            #region bonus
            static void bonus()
            {
                Console.Title = ("иди отсюда пока не поздно");
                Console.WriteLine("Вот и зачем ты нажал 7? это недостроенный бонусный уровень, как тебя зовут?");
                string u_name = Console.ReadLine();
                // Console.WriteLine("пока пока " + u_name + " кликни чтонибудь для возврата в меню и не возвращайся");


                Console.WriteLine("Привет " + u_name + " я попрошу ввести тебя число со знаком после запятой, к примеру 11,1233 , и мы попрубуем округлить число в большую и меньшую сторону. " +
                    "а затем конвертировать значение в новые переменные и затем объявить их" + "");

                Console.WriteLine("{0,5} {1,20:R}  {2,12} {3,15}\n",
                            "Value", "Full Precision", "ToEven",
                            "AwayFromZero");
                double value = 11.1;
                /* double znachenie = Convert.ToDouble(Console.ReadLine()); */

            for (int ctr = 0; ctr <= 5; ctr++)
                    value = RoundValueAndAdd(value);

                Console.WriteLine();

                value = 11.5;
                RoundValueAndAdd(value);


                /* ZnachenieM(znachenie);
                Console.WriteLine("{0,5:N1} {0,20:R} MidpointRounding.ToEven  || {1,12} {2,15} znachenie, MidpointRounding.AwayFromZero",
                                  znachenie, Math.Round(znachenie, MidpointRounding.ToEven),
                                  Math.Round(znachenie, MidpointRounding.AwayFromZero));*/



                /* // Я вроде разобрался с округлениями, сейчас напишу программу, которая округлит 0,5 в большую сторону и в меньшую сторону*/

                Console.Write("Привет, введи число 16,5 или 17,5 я его округлю в большую сторону и в меньшую");
                double znachenie = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0,0:N0} {1,12}",
                                   znachenie, Math.Round(znachenie, MidpointRounding.ToEven),
                                   Math.Round(znachenie, MidpointRounding.AwayFromZero));
                // осталось понять как сохранить полученные результаты как int 32
            }

            private static double RoundValueAndAdd(double value) // пробовал зачемто выполнять внутри этого метода манипуляции со znachenie, щас пишу новый метод
            {
                Console.WriteLine("{0,5:N1} {0,20:R} {0,0:N0} {1,12} {2,15}",
                                  value, Math.Round(value, MidpointRounding.ToEven),
                                  Math.Round(value, MidpointRounding.AwayFromZero));
                return value + .1; // 
            }

            private static double ZnachenieM(double znachenie) // пробовал зачемто выполнять внутри этого метода манипуляции со znachenie, щас пишу новый метод
            {
                Console.WriteLine("{0,5:N1} {0,20:R} {0,0:R}  {1,12} {2,15}",
                                  znachenie, Math.Round(znachenie, MidpointRounding.ToEven),
                                  Math.Round(znachenie, MidpointRounding.AwayFromZero));
                return znachenie + .1;
            }
            /*class arttem //создал класс внутри класса щас методы буду изучать принт и пауза
            {

            }*/
            #endregion

            #region задание 7

            #endregion
        }


    }
