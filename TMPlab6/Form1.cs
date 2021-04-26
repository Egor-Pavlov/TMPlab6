using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMPlab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<(double, double)> points = new List<(double, double)>();
            points.Add((3, 4));
            points.Add((2, 3.5));
            points.Add((5, 7));

            ShadowLengh.CalcLengh(points);
        }

    }
}
