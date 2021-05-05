using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            List<List<string>> result = new List<List<string>>();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = File.ReadAllText(filename);

            if (fileText == "")
            {
                List<string> message = new List<string>();
                message.Add("File is empty.");
                result.Add(message);

            }


            var TestStrings = fileText.Split('\n');//разбиваем на строки 1 строка = 1 набор вх данных
            bool flag = true;

            for(int j = 0; j < TestStrings.Length; j++)
            { 
                var text = TestStrings[j].Split(' ');

                List<(double, double)> points = new List<(double, double)>();
                try
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        var point = text[i].Split(';');
                        if (Convert.ToDouble(point[0]) < Convert.ToDouble(point[1]))
                        {
                            points.Add((Convert.ToDouble(point[0]), Convert.ToDouble(point[1])));
                        }
                        else
                        {
                            List<string> message = new List<string>();
                            message.Add("the coordinate of the end of the line must be greater than the coordinate of the beginning.");
                            result.Add(message);

                            flag = false;
                            break;
                        }
                    }
                    if(flag)
                        result.Add(ShadowLengh.Calc(points));

                    points.Clear();
                }
                catch
                {
                    List<string> message = new List<string>();
                    message.Add("invalid coords.");
                    result.Add(message);

                    continue;
                }
            }

            string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
            Directory.CreateDirectory(completedPath);

            string filePath = Path.Combine(completedPath, filename + "_LinesBlackBox" +".xls");

            //запись в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Input" + "\t" + "Output");
                for (int i = 0; i < result.Count; i++)
                {
                    writer.WriteLine(TestStrings[i].Trim() + "\t" + result[i].Last());
                }
            }


            completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
            Directory.CreateDirectory(completedPath);

            filePath = Path.Combine(completedPath, filename + "_LinesWhitekBox" + ".xls");

            //запись в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string res;
                writer.WriteLine("Input" + "\t" + "Sorted\tSum");
                for (int i = 0; i < result.Count; i++)
                {
                    res = "";
                    for (int j = 0; j < result[i].Count; j++ )
                    {
                        res += result[i][j] + "\t";
                    }
                    writer.WriteLine(TestStrings[i].Trim() + "\t" + res);

                }
            }
        }    

        private void TypeofGraph_BTN_Click(object sender, EventArgs e)
        {
            List<double> Coeffs = new List<double>();
            
            List<string> result = new List<string>();
            
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = File.ReadAllText(filename);

            if (fileText == "")
                result.Add("File is empty.");

            var TestStrings = fileText.Split('\n');//разбиваем на строки 1 строка = 1 набор вх данных

            for(int j = 0; j < TestStrings.Length; j++)
            {
                try
                {
                    var coefs = TestStrings[j].Split(' ');

                    for(int m = 0; m < coefs.Length; m++)
                    {
                        Coeffs.Add(Convert.ToDouble(coefs[m]));
                    }

                    result.Add(TypeOfGraphic.Define(Coeffs));
                    Coeffs.Clear();
                }
                catch
                {
                    result.Add("Invalid coeffs");
                    
                }
            }


            string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
            Directory.CreateDirectory(completedPath);

            string filePath = Path.Combine(completedPath, filename + "_TypeOfGraphicsTest" + ".xls");

            //запись в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Input" + "\t" + "D\td\tType");
                for (int i = 0; i < result.Count; i++)
                {
                    writer.WriteLine(TestStrings[i].Trim() + "\t" + result[i]);
                }
            }

        }
    }
}
