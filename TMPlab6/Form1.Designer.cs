
namespace TMPlab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LinesGP = new System.Windows.Forms.GroupBox();
            this.GraphGP = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShadowLehghBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A_TB = new System.Windows.Forms.TextBox();
            this.D_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.E_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.C_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.B_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.F_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TypeofGraph_BTN = new System.Windows.Forms.Button();
            this.LinesGP.SuspendLayout();
            this.GraphGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinesGP
            // 
            this.LinesGP.Controls.Add(this.ShadowLehghBTN);
            this.LinesGP.Controls.Add(this.label2);
            this.LinesGP.Controls.Add(this.label1);
            this.LinesGP.Controls.Add(this.richTextBox1);
            this.LinesGP.Location = new System.Drawing.Point(15, 15);
            this.LinesGP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LinesGP.Name = "LinesGP";
            this.LinesGP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LinesGP.Size = new System.Drawing.Size(514, 465);
            this.LinesGP.TabIndex = 0;
            this.LinesGP.TabStop = false;
            this.LinesGP.Text = "Тень от линий";
            // 
            // GraphGP
            // 
            this.GraphGP.Controls.Add(this.TypeofGraph_BTN);
            this.GraphGP.Controls.Add(this.label10);
            this.GraphGP.Controls.Add(this.F_TB);
            this.GraphGP.Controls.Add(this.label9);
            this.GraphGP.Controls.Add(this.B_TB);
            this.GraphGP.Controls.Add(this.label8);
            this.GraphGP.Controls.Add(this.C_TB);
            this.GraphGP.Controls.Add(this.label7);
            this.GraphGP.Controls.Add(this.E_TB);
            this.GraphGP.Controls.Add(this.label6);
            this.GraphGP.Controls.Add(this.D_TB);
            this.GraphGP.Controls.Add(this.label5);
            this.GraphGP.Controls.Add(this.A_TB);
            this.GraphGP.Controls.Add(this.label4);
            this.GraphGP.Controls.Add(this.label3);
            this.GraphGP.Location = new System.Drawing.Point(558, 15);
            this.GraphGP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GraphGP.Name = "GraphGP";
            this.GraphGP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GraphGP.Size = new System.Drawing.Size(550, 465);
            this.GraphGP.TabIndex = 1;
            this.GraphGP.TabStop = false;
            this.GraphGP.Text = "Форма графика";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 84);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 112);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите координаты в формате: х1;х2 х1;х2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // ShadowLehghBTN
            // 
            this.ShadowLehghBTN.Location = new System.Drawing.Point(48, 356);
            this.ShadowLehghBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShadowLehghBTN.Name = "ShadowLehghBTN";
            this.ShadowLehghBTN.Size = new System.Drawing.Size(383, 84);
            this.ShadowLehghBTN.TabIndex = 3;
            this.ShadowLehghBTN.Text = "Рассчитать суммарную длину теней";
            this.ShadowLehghBTN.UseVisualStyleBackColor = true;
            this.ShadowLehghBTN.Click += new System.EventHandler(this.ShadowLehghBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Уравнение имеет вид: Ax^2+2Bxy+Cy^2+2Dx+2Ey+F=0.\r\nВведите коэффициенты А, B, C, D" +
    ", E, F.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "A:";
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(22, 126);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(100, 27);
            this.A_TB.TabIndex = 2;
            // 
            // D_TB
            // 
            this.D_TB.Location = new System.Drawing.Point(175, 126);
            this.D_TB.Name = "D_TB";
            this.D_TB.Size = new System.Drawing.Size(100, 27);
            this.D_TB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "E:";
            // 
            // E_TB
            // 
            this.E_TB.Location = new System.Drawing.Point(171, 180);
            this.E_TB.Name = "E_TB";
            this.E_TB.Size = new System.Drawing.Size(100, 27);
            this.E_TB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "D:";
            // 
            // C_TB
            // 
            this.C_TB.Location = new System.Drawing.Point(22, 234);
            this.C_TB.Name = "C_TB";
            this.C_TB.Size = new System.Drawing.Size(100, 27);
            this.C_TB.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "C:";
            // 
            // B_TB
            // 
            this.B_TB.Location = new System.Drawing.Point(22, 180);
            this.B_TB.Name = "B_TB";
            this.B_TB.Size = new System.Drawing.Size(100, 27);
            this.B_TB.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "B:";
            // 
            // F_TB
            // 
            this.F_TB.Location = new System.Drawing.Point(171, 234);
            this.F_TB.Name = "F_TB";
            this.F_TB.Size = new System.Drawing.Size(100, 27);
            this.F_TB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "F:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 13;
            // 
            // TypeofGraph_BTN
            // 
            this.TypeofGraph_BTN.Location = new System.Drawing.Point(141, 356);
            this.TypeofGraph_BTN.Name = "TypeofGraph_BTN";
            this.TypeofGraph_BTN.Size = new System.Drawing.Size(274, 84);
            this.TypeofGraph_BTN.TabIndex = 8;
            this.TypeofGraph_BTN.Text = "Определить вид графика";
            this.TypeofGraph_BTN.UseVisualStyleBackColor = true;
            this.TypeofGraph_BTN.Click += new System.EventHandler(this.TypeofGraph_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 492);
            this.Controls.Add(this.GraphGP);
            this.Controls.Add(this.LinesGP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LinesGP.ResumeLayout(false);
            this.LinesGP.PerformLayout();
            this.GraphGP.ResumeLayout(false);
            this.GraphGP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LinesGP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox GraphGP;
        private System.Windows.Forms.Button ShadowLehghBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TypeofGraph_BTN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox F_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox B_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox C_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox E_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox D_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

