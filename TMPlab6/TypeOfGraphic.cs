using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TMPlab6
{
    class TypeOfGraphic
    {
        public static string Define(List<double> Coeffs) //лист хранит коэффициенты ABCDEF
        {
            double D = 0, d = 0;
            if(Coeffs.Count != 6)
            {
                throw new ArgumentException();
            }

            D = Coeffs[0] * Coeffs[2] * Coeffs[5] + Coeffs[1] * Coeffs[4] * Coeffs[3] + Coeffs[1] * Coeffs[4] * Coeffs[3] -
                Coeffs[3] * Coeffs[2] * Coeffs[3] - Coeffs[1] * Coeffs[1] * Coeffs[5] - Coeffs[0] * Coeffs[4] * Coeffs[4];
            d = Coeffs[0] * Coeffs[2] - Coeffs[1] * Coeffs[1];
            
            if(D == 0)
            {
                if (d > 0)
                {
                    return "D = " + D + "\td = "+ d +"\tPoint";
                }
                else if (d < 0)
                {
                    return "D = " + D + "\td = " + d + "\tCrossed lines";
                }

                return "D = " + D + "\td = " + d + "\tParallel Lines";

            }
            else if(d < 0)
            {
                return "D = " + D + "\td = " + d + "\tHyperbole";
            }
            else if (d > 0)
            {
                return "D = " + D + "\td = " + d + "\tEllipse";
            }
            
            return "D = " + D + "\td = " + d + "\tParabole";
            
        }
    }
}
