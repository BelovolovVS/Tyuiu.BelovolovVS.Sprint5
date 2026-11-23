using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BelovolovVS.Sprint5.Task1.V11.Lib;

namespace Tyuiu.BelovolovVS.Sprint5.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Беловолов В. С. | Группа: ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Беловолов В. С. | Группа: ПИНб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (sin(x)-2x)/(3x-1) + sin(x) - 3x + 2.               *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.           *");
            Console.WriteLine("* При делении на ноль вернуть 0. Результат сохранить в OutPutFileTask1.txt*");
            Console.WriteLine("* и вывести на консоль в таблицу. Округлить до двух знаков после запятой. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine();
            
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                if ((3 * x - 1) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2;
                }
                y = Math.Round(y, 2);

                Console.WriteLine($"|{x,10:F1}|{y,10:F2}|");
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}