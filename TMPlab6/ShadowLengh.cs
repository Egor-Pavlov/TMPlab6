using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPlab6
{
    class ShadowLengh
    {
        public static double Calc(List<(double, double)> lines)
        {
            if (lines.Count == 0)
                throw new ArgumentException();

            List<double> X1 = new List<double>();
            List<double> X2 = new List<double>();
            double sum = 0;
            //разбиваем массив пар на 2 массива
            for (int i = 0; i < lines.Count; i++)
            {
                X1.Add(lines[i].Item1);
                X2.Add(lines[i].Item2);
            }

            double x1, x2;
            //сортируем линии. в начале списка та которая начинается левее всех
            for (int i = 0; i < lines.Count - 1; i++)
            {
                if(X1[i] > X1[i+1])
                {
                    x1 = X1[i];
                    x2 = X2[i];
                    X1[i] = X1[i + 1];
                    X2[i] = X2[i + 1];
                    X1[i + 1] = x1;
                    X2[i + 1] = x2;
                }
            }
            //вычисляем сумму
            sum += X2[0] - X1[0];
            for (int i = 0; i < lines.Count - 1; i++)
            {
                if(X1[i + 1] <= X2[i])
                {
                    if(X2[i+1] <= X2[i])
                    {
                        continue;
                    }
                    sum += X2[i + 1] - X2[i];
                    continue;
                }
                sum += X2[i + 1] - X1[i + 1];
            }

            return sum;
        }
    }
}
