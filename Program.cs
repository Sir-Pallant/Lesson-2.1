using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonv2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Задача 1

            double a, b, c;
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            c = int.Parse(Console.ReadLine());
            double small = Math.Min(a, Math.Min(b, c));
            Console.WriteLine($"Наименьшее введенное число   {small}");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Задача 2

            Console.WriteLine("Введите число : ");
            string str = Console.ReadLine();
            double number;
            int counter = 0;
            if (double.TryParse(str, out number))
            {
                foreach (char i in str)
                {
                    if (i >= '0' && i <= '9') counter++;
                }
            }
            else
                Console.WriteLine("Некорректный ввод...");
            Console.WriteLine("Ваше число {0} состоит из {1} знаков", number, counter);
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Задача 3
            uint sum = 0;
            uint number1 = 0;

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number1 % 2 == 1)
                    sum += number1;

            } while (number1 != 0);

            Console.WriteLine($"Сумма нечетных положительных чисел =   {sum}");
            Console.Clear();
            #endregion


            #region Задача 4
            string login = "root";
            string pass = "GeekBrains";
            int counter1 = 3;
            do
            {
                Console.WriteLine("Введите логин : ");
                string userlogin = Console.ReadLine();
                Console.WriteLine("Введите пароль : ");
                string userpass = Console.ReadLine();

                if (login == userlogin && pass == userpass)
                {
                    Console.WriteLine("Добро пожаловать");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine($"Неверно введен логин или пароль. Попыток осталось  {--counter1}");
                Console.ReadLine();
            } while (counter1 != 0);
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задача 5

            Console.Write(Environment.NewLine + "Введите Ваш вес в кг: ");
            double mass = double.Parse(Console.ReadLine());

            Console.Write("Введите рост человека в см: ");
            double heigth = double.Parse(Console.ReadLine());

            heigth /= 100;

            Console.Write(Environment.NewLine + "Индекс массы тела: ");
            double BMI = mass / (heigth * heigth);
            Console.WriteLine("{0:0.##}", BMI);

            Console.WriteLine(Norm(BMI, heigth));

            Console.ReadKey();
        }
            static string Norm(double bmi, double heigth)
            {
                string result = "";
                if (bmi >= 18.5 && bmi <= 24.99)
                {
                    result = "Всё в норме!";
                }
                else if (bmi < 18.5)
                {
                    double recommendation = (18.5 - bmi) * heigth * heigth;
                    result = String.Format("Необходимо набрать {0:0.00} кг для нормализации веса!", recommendation);
                }
                else if (bmi > 24.99)
                {
                    double recommendation = (bmi - 24.99) * heigth * heigth;
                    result = String.Format("Необходимо сбросить {0:0.00} кг для нормализации веса!", recommendation);
                }

                return result;
            
            #endregion
       }

    }

  }

    
    
  
    



        
    

