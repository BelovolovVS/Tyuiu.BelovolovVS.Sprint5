using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BelovolovVS.Sprint5.Task5.V5.Lib;

namespace Tyuiu.BelovolovVS.Sprint5.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Беловолов В. С. | Группа: ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Беловолов В. С. | Группа: ПИНб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V5.txt в котором есть набор *");
            Console.WriteLine("* значений. Найти разницу между максимальным и минимальным целыми         *");
            Console.WriteLine("* числами в файле. Полученный результат вывести на консоль.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V5.txt";
            
            if (!File.Exists(path))
            {
                path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V5.txt");
                File.WriteAllText(path, "1.5\n2\n-3\n4.7\n5\n-1\n10");
            }

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Разница между максимальным и минимальным целыми числами = " + res);

            Console.ReadKey();
        }
    }
}