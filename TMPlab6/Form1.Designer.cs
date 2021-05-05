
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
            this.ShadowLehghBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GraphGP = new System.Windows.Forms.GroupBox();
            this.TypeofGraph_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LinesGP.SuspendLayout();
            this.GraphGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinesGP
            // 
            this.LinesGP.Controls.Add(this.ShadowLehghBTN);
            this.LinesGP.Controls.Add(this.label1);
            this.LinesGP.Location = new System.Drawing.Point(15, 15);
            this.LinesGP.Margin = new System.Windows.Forms.Padding(4);
            this.LinesGP.Name = "LinesGP";
            this.LinesGP.Padding = new System.Windows.Forms.Padding(4);
            this.LinesGP.Size = new System.Drawing.Size(514, 292);
            this.LinesGP.TabIndex = 0;
            this.LinesGP.TabStop = false;
            this.LinesGP.Text = "Тень от линий";
            // 
            // ShadowLehghBTN
            // 
            this.ShadowLehghBTN.Location = new System.Drawing.Point(51, 182);
            this.ShadowLehghBTN.Margin = new System.Windows.Forms.Padding(4);
            this.ShadowLehghBTN.Name = "ShadowLehghBTN";
            this.ShadowLehghBTN.Size = new System.Drawing.Size(383, 84);
            this.ShadowLehghBTN.TabIndex = 3;
            this.ShadowLehghBTN.Text = "Тестировать\r\n";
            this.ShadowLehghBTN.UseVisualStyleBackColor = true;
            this.ShadowLehghBTN.Click += new System.EventHandler(this.ShadowLehghBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл с входными данными для тестирования.\r\n";
            // 
            // GraphGP
            // 
            this.GraphGP.Controls.Add(this.TypeofGraph_BTN);
            this.GraphGP.Controls.Add(this.label3);
            this.GraphGP.Location = new System.Drawing.Point(558, 15);
            this.GraphGP.Margin = new System.Windows.Forms.Padding(4);
            this.GraphGP.Name = "GraphGP";
            this.GraphGP.Padding = new System.Windows.Forms.Padding(4);
            this.GraphGP.Size = new System.Drawing.Size(550, 292);
            this.GraphGP.TabIndex = 1;
            this.GraphGP.TabStop = false;
            this.GraphGP.Text = "Форма графика";
            // 
            // TypeofGraph_BTN
            // 
            this.TypeofGraph_BTN.Location = new System.Drawing.Point(134, 182);
            this.TypeofGraph_BTN.Name = "TypeofGraph_BTN";
            this.TypeofGraph_BTN.Size = new System.Drawing.Size(274, 84);
            this.TypeofGraph_BTN.TabIndex = 8;
            this.TypeofGraph_BTN.Text = "Тестировать\r\n";
            this.TypeofGraph_BTN.UseVisualStyleBackColor = true;
            this.TypeofGraph_BTN.Click += new System.EventHandler(this.TypeofGraph_BTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберите файл с входными данными для тестирования:\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 320);
            this.Controls.Add(this.GraphGP);
            this.Controls.Add(this.LinesGP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.GroupBox GraphGP;
        private System.Windows.Forms.Button ShadowLehghBTN;
        private System.Windows.Forms.Button TypeofGraph_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

