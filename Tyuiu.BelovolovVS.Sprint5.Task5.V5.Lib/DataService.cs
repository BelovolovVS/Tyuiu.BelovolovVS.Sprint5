using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BelovolovVS.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            List<int> integers = new List<int>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Replace(',', '.').Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string val in values)
                    {
                        double num = Convert.ToDouble(val, CultureInfo.InvariantCulture);
                        
                        if (num == Math.Truncate(num))
                        {
                            integers.Add((int)num);
                        }
                    }
                }
            }

            int max = integers.Max();
            int min = integers.Min();

            double res = max - min;
            return Math.Round(res, 3);
        }
    }
}