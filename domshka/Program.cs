
Skip to content
Pull requests
Issues
Marketplace
Explore
@jenkeee
jenkeee /
dz2

1
0

    0

Code
Issues
Pull requests 2
Actions
Projects
Wiki
Security
Insights

    Settings

dz2/domshka/Program.cs /
@jenkeee
jenkeee Update Program.cs
Latest commit 691940b 5 hours ago
History
1 contributor
666 lines (577 sloc) 36.5 KB
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
                Console.WriteLine("Введите номер задачи 1-7, прочие символы не нравятся приложению, ??? ");
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
                        dz7();
                        break;
                    case 8:
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
            double i_id_up;
            double we_1;
            double we_2;
            i_id = 18.5 - I; // i_id разница между желаемым минимум и фактическим значением
            i_id_up = 25 - I; //i_id_up разница между желаемым максимумом и фактическим значением
            we_1 = i_id * (Math.Pow(high / 100, 2)); // we_1 это вес который необходимо добавить до порого идеального минимума
            we_2 = i_id_up * (Math.Pow(high / 100, 2)); // we_2 это вес который необходимо добавить до порого идеального максимума

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
                //i_id = 25 - I;
                //i_id_up = 18.5 - I;
                //we_1 = i_id * (Math.Pow(high / 100, 2));
                //we_2 = i_id_up * (Math.Pow(high / 100, 2));
                we_1 = we_1 + we_2;
                we_2 = we_1 - we_2;
                we_1 = we_1 - we_2;
                we_1 = -we_1;
                we_2 = -we_2;
               
                Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
            }
            else if (I >= 30 && I < 35)
            {
                Console.WriteLine("Ожирение I степени");
                //i_id = 25 - I;
                //i_id_up = 18.5 - I;
                //we_1 = i_id * (Math.Pow(high / 100, 2));
                //we_2 = i_id_up * (Math.Pow(high / 100, 2));
                //we_1 = -we_1;
                //we_2 = -we_2;
                we_1 = we_1 + we_2;
                we_2 = we_1 - we_2;
                we_1 = we_1 - we_2;
                we_1 = -we_1;
                we_2 = -we_2;
                Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
            }
            else if (I >= 35 && I < 40)
            {
                Console.WriteLine("Ожирение II степени");
                //i_id = 25 - I;
                //i_id_up = 18.5 - I;
                //we_1 = i_id * (Math.Pow(high / 100, 2));
                //we_2 = i_id_up * (Math.Pow(high / 100, 2));
                //we_1 = -we_1;
                //we_2 = -we_2;
                we_1 = we_1 + we_2;
                we_2 = we_1 - we_2;
                we_1 = we_1 - we_2;
                we_1 = -we_1;
                we_2 = -we_2;
                Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
            }
            else if (I >= 40)
            {
                Console.WriteLine("Ожирение III степени");
                //i_id = 25 - I;
                //i_id_up = 18.5 - I;
                //we_1 = i_id * (Math.Pow(high / 100, 2));
                //we_2 = i_id_up * (Math.Pow(high / 100, 2));
                //we_1 = -we_1;
                //we_2 = -we_2;
                we_1 = we_1 + we_2;
                we_2 = we_1 - we_2;
                we_1 = we_1 - we_2;
                we_1 = -we_1;
                we_2 = -we_2;
                Console.WriteLine("Вам стоит сбросить минимум " + we_1 + " кг для нормального веса. но не больше  " + we_2);
            }
            else { Console.WriteLine("неведомая зверушка"); }


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
        ///  6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        /// «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        /// </summary>
        static void dz6()
            {
            Console.Clear();
            /*
            Console.WriteLine("Сейчас мы займемся счетом хороших чисел в указанном диапазоне, изначально по условиям диапазон я задавал сам, но я дамю возможность изменить диапазон проверяющему");
            Console.WriteLine("Введите число, от которого мы будем считать хорошие числа");
            int x_start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число, до которого мы будем считать хорошие числа");
            int x_end = Convert.ToInt32(Console.ReadLine());
            */
            Console.WriteLine("Подождите, идёт подсчёт количества 'хороших' чисел в заданном диапазоне");
            Console.WriteLine("Время начала операции " + DateTime.Now);
            
            int start_timer = DateTime.Now.Second;  // записываем время начала счета в переменную

            Console.SetCursorPosition(0, 10); Console.Write("Обрабатывается число: ");
            Console.SetCursorPosition(0, 11); Console.Write("Найдено: ");

            var GoodNum = 0; // объявляем хорошие числа
            int range = 1_000_000_000; // до какого числа считаем
            bool flag_stop = !true;

            //////////////////////////////////////////////////////////////////////////////////////////////
            for (var gn_first = 1; gn_first <= range; gn_first++) // делаем бесконечный цикл 
                                                                  // (var gn_first = 1; задаем значение точка старта счета
                                                                  //gn_first <= range;  будет считать пока не меньше либо равно 
                                                                  // gn_first++) : каждый раз выполняя цикл , мы меняем значение gn_first на + 1
            {
                Console.SetCursorPosition(23, 10); Console.Write(gn_first); // пишем какое число сейчас у нас в gn_first

                // делаем если и вызываем метод который в случае выполнения даст нам GoodNum + 1 и выведет на экран полученное в заданном месте
                // Console.SetCursorPosition(10, 5); Console.Write(GoodNum); 

                if (GoodNumCheck(gn_first)) { GoodNum++; Console.SetCursorPosition(10, 11); Console.Write(GoodNum);
                    //Console.ReadKey();
                }
                
               //else if (flag_stop == !true) break;
            } 
            //////////////////////////////////////////////////////////
            ///
            Console.SetCursorPosition(23, 10); Console.Write(range);
            Console.SetCursorPosition(10, 11); Console.Write(GoodNum);
            Console.WriteLine();
            Console.WriteLine();
            start_timer =  start_timer - DateTime.Now.Second; // посчитаем сколько времени мы потратили на выполнение цикла где делали 
            //gn_first + 1 пока не <= range 

            Console.WriteLine("Время окончания операции " + DateTime.Now); 
            Console.WriteLine("Потрачено секунд на выполнение: " + start_timer);

                       NextPart();
            
        }
        private static bool GoodNumCheck(int x_metha) // метод который определит число хорошее или нет
                                                // у нас есть условие if (GoodNumCheck(gn_first)) 
                                                // этим условием мы берем значение gn_first и ставим его в x_metha
        {

            // «Хорошим» называется число, которое делится на сумму своих цифр.
            var good = false; 
            var holder = x_metha; // на каждый вызов метода  x_metha будет меняться // но и мы перезапишем холдер
            var sum_6 = 0; // сумма чисел
            var a = 0;
            do
            {
                a = x_metha % 10; // % это логическая операция остаток от деления в данном случае остаток от деления на 10
                // мы начинаем считать хорошие числа от 0 поэтому даем 0 -  var sum_6 = 0;
                // считаем первую сумму потом будем делить на неё


                sum_6 = sum_6 + a; // получаем значение второго символа

                x_metha = x_metha / 10; // получаем десятки
            } while (x_metha >= 1); // будем гонять цикл пока первый сивол не бут =1
            if (holder % sum_6 == 0) { good = true; } // если число которое мы запомнили до того как начали гонять цикл делится без остатка на крайний знак перед нулем // остаток от числа x_metha / значит число хорошее
            return good;
        }
        private static void NextPart()
        {
            Console.ReadKey();
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить:");
            Console.Clear();
            
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
        // 6 заданий позади 
        static void dz7()
        {
            Console.WriteLine("tocheck");
            PrintNumber(1, 12);
            Console.WriteLine("мы видим результат PrintNumber(1, 12);");
            Console.WriteLine("рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine("Нажми любую клавишу чтобы увидеть SumNumber(1, 5)");
            Console.ReadKey();
            SumNumber(1, 5);
            Console.WriteLine("это рекурсивный метод, который считает сумму чисел от a до b.");

        }
        /// <summary>
        /// Станислав спасибо, сейчас вызову эти методы в dz7 // 
        /// Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b). 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void PrintNumber(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                a++;
                PrintNumber(a, b);
            }
        }
        /// <summary>
        /// Разработать рекурсивный метод, который считает сумму чисел от a до b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int SumNumber(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine($"{a} + {b} = {a+b}"); // добавим в консоль отображение функции
                var sum = SumNumber(a + 1, b);
                return a + sum;
                
            }
            return 0;
        }
        #endregion
    }


    }

    © 2021 GitHub, Inc.
    Terms
    Privacy
    Security
    Status
    Docs

    Contact GitHub
    Pricing
    API
    Training
    Blog
    About

Loading complete
