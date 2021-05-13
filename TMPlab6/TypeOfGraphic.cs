using System;
using System.Collections.Generic;

namespace TMPlab6
{
    class TypeOfGraphic
    {
        public static List<string> Define(List<double> Coeffs) //лист хранит коэффициенты ABCDEF
        {
            List<string> res = new List<string>();
            double D = 0, d = 0;
            if (Coeffs.Count != 6)
            {
                throw new ArgumentException();
            }

            D = Coeffs[0] * Coeffs[2] * Coeffs[5] + Coeffs[1] * Coeffs[4] * Coeffs[3] + Coeffs[1] * Coeffs[4] * Coeffs[3] -
                Coeffs[3] * Coeffs[2] * Coeffs[3] - Coeffs[1] * Coeffs[1] * Coeffs[5] - Coeffs[0] * Coeffs[4] * Coeffs[4];
            d = Coeffs[0] * Coeffs[2] - Coeffs[1] * Coeffs[1];

            res.Add(D.ToString());
            res.Add(d.ToString());

            if (D == 0)
            {
                if (d > 0)
                {
                    res.Add("Point");
                    return res;
                }
                else if (d < 0)
                {
                    res.Add("Crossed_lines");
                    return res;
                }
                res.Add("Parallel_Lines");
                return res;
            }
            else if (d < 0)
            {
                res.Add("Hyperbole");
                return res;
            }
            else if (d > 0)
            {
                res.Add("Ellipse");
                return res;
            }
            res.Add("Parabole");
            return res;
        }
    }
}
