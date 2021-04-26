using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPlab6
{
    class ShadowLengh
    {
        public static double CalcLengh(List<(double, double)> lines)
        {
            double sum = 0;
            for(int i = 0; i < lines.Count; i++)
            {
                sum += (lines[i].Item2 - lines[i].Item1);
            }
            return sum;
        }
    }
}
