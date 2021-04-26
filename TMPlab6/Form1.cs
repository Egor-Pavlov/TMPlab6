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
        }

        private void ShadowLehghBTN_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "")
            {
                MessageBox.Show("Координаты не введены.");
                return;
            }

            var text = richTextBox1.Text.Split(' ');
            List<(double, double)> points = new List<(double, double)>();
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    var point = text[i].Split(';');
                    if (Convert.ToDouble(point[0]) < Convert.ToDouble(point[1]))
                        points.Add((Convert.ToDouble(point[0]), Convert.ToDouble(point[1])));
                    else
                    {
                        MessageBox.Show("Координата конца линии должна быть больше координаты начала.");
                        richTextBox1.Clear();
                        return;
                    }
                }
                label2.Text = "Суммарная длина тени равна " + ShadowLengh.Calc(points).ToString();
            }
            catch
            {
                MessageBox.Show("Координаты Введены некорректно.");
                richTextBox1.Clear();
                return;
            }
        }
        

        private void TypeofGraph_BTN_Click(object sender, EventArgs e)
        {
            List<double> Coeffs = new List<double>();
            try
            {
                Coeffs.Add(Convert.ToDouble(A_TB.Text));
                Coeffs.Add(Convert.ToDouble(B_TB.Text));
                Coeffs.Add(Convert.ToDouble(C_TB.Text));
                Coeffs.Add(Convert.ToDouble(D_TB.Text));
                Coeffs.Add(Convert.ToDouble(E_TB.Text));
                Coeffs.Add(Convert.ToDouble(F_TB.Text));

                label10.Text = "Тип графика: " + TypeOfGraphic.Define(Coeffs);
            }
            catch
            {
                MessageBox.Show("Коэффициенты введены некорректно.");
                A_TB.Clear();
                B_TB.Clear();
                C_TB.Clear();
                D_TB.Clear();
                E_TB.Clear();
                F_TB.Clear();
                return;
            }
        }
    }
}
