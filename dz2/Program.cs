using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    class Program
    {  //Губарь Артём
        static void Main(string[] args) 
        {
            Console.WriteLine("1 - Задача 1");
            Console.WriteLine("2 - Задача 2");
            Console.WriteLine("3 - Задача 3");
            Console.WriteLine("5 - Задача 5");
            Console.WriteLine("7 - Задача 7");
            Console.WriteLine("0 - Завершение работы.");
            while (true)
            {
                Console.WriteLine("Введите номер задачи");
                int TaskNumber = int.Parse(Console.ReadLine());
                switch (TaskNumber)
                {
                    case 0:
                        Console.WriteLine("Завершение работы программы");
                        Console.Read();
                        return;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 7:
                        Task7();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Пожалуйста, повторите ввод.");
                        break;
                }
            }
        }
        static void Task1()
        {
            #region Задание 1
            //Написать метод, возвращающий минимальное из трёх чисел.
            Console.Title = "Минимальное число";
            Console.WriteLine("Введите три любых числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (c < b && c < a)
                { Console.WriteLine($"Минимальное число {c}");}
            if (a > b && b < c)
                { Console.WriteLine($"Минимальное число {b}");}
            if (a < b && a < c)
                { Console.WriteLine($"Минимальное число {a}");}
            #endregion
        }
        static void Task2()
        {
            #region Задание 2
            //Написать метод подсчета количества цифр числа.
            Console.Title = "Подсчёт цифр числа";
            Console.WriteLine("Введите число");
            int d = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (d > 0)
            {
                i++;
                d /= 10;
            }
            Console.WriteLine($"В заданном числе {i} цифр(ы)");
            #endregion
        }
        static void Task3()
        {
            #region Задание 3
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.Title = "Сумма всех нечётных положительных чисел";
            int h, j = 0;
            do
            {
                Console.WriteLine("Введите любое число");
                h = Convert.ToInt32(Console.ReadLine());
                if (h > 0 && h % 2 != 0)
                {
                    j++;
                }

            }
            while (h != 0);
            if (j == 1)
            {
                Console.WriteLine($"Введено {j} положительное нечётное число");
            }
            if (j > 1 && j < 5)
            {
                Console.WriteLine($"Введено {j} положительных нечётных числа");
            }
            if (j > 4)
            {
                Console.WriteLine($"Введено {j} положительных нечётных чисел");
            }
            #endregion
        }
        static void Task5()
        {
            #region Задание 5
            /*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
            нужно ли человеку похудеть, набрать вес или всё в норме.*/
            Console.Title = "Анализ индекса массы тела";
            double I;
            Console.WriteLine("Введите ваш вес");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            double H = Convert.ToDouble(Console.ReadLine());
            I = m / (H * H);
            if ( I < 16)
            { Console.WriteLine($"ИМТ = {I}. У вас выраженный дефицит массы тела!!! Немедленно обратитесь к специалисту!!!"); }
            if (I >= 16 && I < 18.5)
            { Console.WriteLine($"ИМТ = {I}. У вас недостаточная (дефицит) масса тела. Вам необходимо набрать вес."); }
            if (I >= 18.5 && I < 25)
            { Console.WriteLine($"ИМТ = {I}. Вы в норме. Так держать!"); }
            if (I >= 25 && I < 30)
            { Console.WriteLine($"ИМТ = {I}. У вас избыточная масса тела. Вам нужно сбросить вес."); }
            if (I >= 30 && I < 35)
            { Console.WriteLine($"ИМТ = {I}. У вас ожирение 1-ой степени! Обратитесь к диетологу!"); }
            if (I >=35 && I < 40)
            { Console.WriteLine($"ИМТ = {I}. У вас ожирение 2-ой степени! Обратитесь к диетологу!"); }
            if (I >= 40)
            { Console.WriteLine($"ИМТ = {I}. У вас ожирение 3-ей степени! Обратитесь к диетологу!"); }
            #endregion
        }
        
        static void Task7()
        {  //Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Print(a, b);
        }

        static void Print(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b)
            { Print(a + 1, b); }
        }
        static void Print1(int a, int b)
        {
            int sum = 0;
            for(int i = 1; a < b; i++)
            {
                Print1(a + 1, b);
                sum = sum + a;
            }
            Console.WriteLine(sum);
        }//????????
    }
}
