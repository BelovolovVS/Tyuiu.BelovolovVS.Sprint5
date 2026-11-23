using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BelovolovVS.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace(',', '.');
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);

            double res = (3 * Math.Pow(x, 3)) / Math.Sin(x);
            res = Math.Round(res, 3);

            return res;
        }
    }
}