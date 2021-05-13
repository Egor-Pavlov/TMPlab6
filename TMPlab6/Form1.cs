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
            List<string[]> result = new List<string[]>();
            
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            
            // читаем файл в строку
            string fileText = File.ReadAllText(filename);

            if (fileText == "")
            {
                string[] arr = new string[1];
                arr[0] = "File is empty.";
                result.Add(arr);
            }


            var TestStrings = fileText.Split('\n');//разбиваем на строки 1 строка = 1 набор вх данных

            for(int j = 0; j < TestStrings.Length; j++)
            {
                var text = TestStrings[j].Split(' ');
                string[] line = new string[5];
                List<(double, double)> points = new List<(double, double)>();

                for(int i = 0; i < text.Length - 1; i++)
                {
                    line[0] += text[i] + " ";
                }

                line[2] = text.Last().Trim();

                try
                {
                    for (int i = 0; i < text.Length - 1; i++)
                    {
                        var point = text[i].Split(';');
                        if (Convert.ToDouble(point[0]) < Convert.ToDouble(point[1]))
                        {
                            points.Add((Convert.ToDouble(point[0]), Convert.ToDouble(point[1])));
                        }
                        else
                        {
                            line[3] = "exception";
                            if (line[3] == line[2])
                            {
                                line[4] = "passed";
                                result.Add(line);
                            }
                            else
                            {
                                line[4] = "not passed";
                                result.Add(line);
                            }
                            break;
                        }
                    }

                    List<string> output = ShadowLengh.Calc(points);

                    line[1] = output[0].Trim();
                    line[3] = output[1].Trim();

                    if(line[3] == line[2])
                    {
                        line[4] = "passed";
                        result.Add(line);
                    }
                    else
                    {
                        line[4] = "not passed";
                        result.Add(line);
                    }

                    points.Clear();
                }
                catch
                {
                    line[3] = "exception";
                    if (line[3] == line[2])
                    {
                        line[4] = "passed";
                        result.Add(line);
                    }
                    else
                    {
                        line[4] = "not passed";
                        result.Add(line);
                    }
                }
            }


            // Запись результатов тестирования в файл
            string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
            Directory.CreateDirectory(completedPath);

            string filePath = Path.Combine(completedPath, filename + "_LinesBlackBox.xls");

            //запись в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Input\tExpected out \toutput \tresult");
                for (int i = 0; i < result.Count; i++)
                {
                    writer.WriteLine(result[i][0] + "\t" + result[i][2] + "\t" + result[i][3] + "\t" + result[i][4]);
                }
            }


            completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
            Directory.CreateDirectory(completedPath);

            filePath = Path.Combine(completedPath, filename + "_LinesWhitekBox" + ".xls");

            //запись в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string res;
                writer.WriteLine("Input\tExpected out \tSorted\toutput \tresult");
                for (int i = 0; i < result.Count; i++)
                {
                    writer.WriteLine(result[i][0] + "\t" + result[i][1] + "\t" + result[i][2] + "\t" + result[i][3] + "\t" + result[i][4]); 

                }
            }
        }    

        private void TypeofGraph_BTN_Click(object sender, EventArgs e)
        {
            List<double> Coeffs = new List<double>();
            List<string[]> result = new List<string[]>();
            
            
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строкy
            string fileText = File.ReadAllText(filename);

            if (fileText == "")
            {
                string[] line = new string[6];
                line[4] = "File is empty.";
                result.Add(line);
            }

            var TestStrings = fileText.Split('\n');//разбиваем на строки 1 строка = 1 набор вх данных

            for(int j = 0; j < TestStrings.Length; j++)
            {
                string[] line = new string[6];
                try
                {
                    var coefs = TestStrings[j].Split(' ');

                    for (int i = 0; i < coefs.Length - 1; i++)
                    {
                        line[0] += coefs[i] + " ";
                    }
                    line[3] = coefs.Last().Trim();//expected type

                    for (int m = 0; m < coefs.Length - 1; m++)
                    {
                        Coeffs.Add(Convert.ToDouble(coefs[m]));
                    }

                    List<string> output = TypeOfGraphic.Define(Coeffs);

                    line[1] = output[0].Trim();//D
                    line[2] = output[1].Trim();//d
                    line[4] = output[2].Trim();//type

                    if (line[3] == line[4])
                    {
                        line[5] = "passed";
                        result.Add(line);
                    }
                    else
                    {
                        line[5] = "not passed";
                        result.Add(line);
                    }

                    Coeffs.Clear();
                }
                catch
                {
                    line[4] = "invalid_coeffs";
                    if (line[3] == line[4])
                    {
                        line[5] = "passed";
                        result.Add(line);
                    }
                    else
                    {
                        line[5] = "not passed";
                        result.Add(line);
                    }

                }
            }


            string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test's");
            Directory.CreateDirectory(completedPath);

            string filePath = Path.Combine(completedPath, filename + "_TypeOfGraphicsTest" + ".xls");

            //запись в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Input\tD\td\tExpected Type\tType\tResult");
                for (int i = 0; i < result.Count; i++)
                {
                    writer.WriteLine(result[i][0] + "\t" + result[i][1] + "\t" + result[i][2] + 
                        "\t" + result[i][3] + "\t" + result[i][4] + "\t" + result[i][5]);
                }
            }

        }
    }
}
