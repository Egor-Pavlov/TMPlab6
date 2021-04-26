using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPlab6
{
    class ShadowLengh
    {
        List<(double, double)> lines = new List<(double, double)>();
        public ShadowLengh(List<(double, double)> lines)
        {
            this.lines = lines;
        }
        public double CalcLengh()
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
