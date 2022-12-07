namespace Z2_Forms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CalculateRoundButton = new System.Windows.Forms.Button();
            this.RoundRadiusTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CalculateSquareButton = new System.Windows.Forms.Button();
            this.SquareSecondTextBox = new System.Windows.Forms.TextBox();
            this.SquareFirstTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CalculateTriangleButton = new System.Windows.Forms.Button();
            this.TriangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.TriangleCoreSideTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TriangleThirdTextBox = new System.Windows.Forms.TextBox();
            this.TriangleSecondTextBox = new System.Windows.Forms.TextBox();
            this.TriangleFirstTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CalculateRoundButton);
            this.tabPage1.Controls.Add(this.RoundRadiusTextBox);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Круг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CalculateRoundButton
            // 
            this.CalculateRoundButton.Location = new System.Drawing.Point(11, 83);
            this.CalculateRoundButton.Name = "CalculateRoundButton";
            this.CalculateRoundButton.Size = new System.Drawing.Size(88, 29);
            this.CalculateRoundButton.TabIndex = 4;
            this.CalculateRoundButton.Text = "Вычислить";
            this.CalculateRoundButton.UseVisualStyleBackColor = true;
            this.CalculateRoundButton.Click += new System.EventHandler(this.CalculateRoundButton_Click);
            // 
            // RoundRadiusTextBox
            // 
            this.RoundRadiusTextBox.Location = new System.Drawing.Point(135, 40);
            this.RoundRadiusTextBox.Name = "RoundRadiusTextBox";
            this.RoundRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoundRadiusTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 24);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Расчет периметра и площади круга";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите радиус круга:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CalculateSquareButton);
            this.tabPage2.Controls.Add(this.SquareSecondTextBox);
            this.tabPage2.Controls.Add(this.SquareFirstTextBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прямоугольник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CalculateSquareButton
            // 
            this.CalculateSquareButton.Location = new System.Drawing.Point(155, 117);
            this.CalculateSquareButton.Name = "CalculateSquareButton";
            this.CalculateSquareButton.Size = new System.Drawing.Size(98, 32);
            this.CalculateSquareButton.TabIndex = 16;
            this.CalculateSquareButton.Text = "Вычислить";
            this.CalculateSquareButton.UseVisualStyleBackColor = true;
            this.CalculateSquareButton.Click += new System.EventHandler(this.CalculateSquareButton_Click);
            // 
            // SquareSecondTextBox
            // 
            this.SquareSecondTextBox.Location = new System.Drawing.Point(208, 74);
            this.SquareSecondTextBox.Name = "SquareSecondTextBox";
            this.SquareSecondTextBox.Size = new System.Drawing.Size(100, 20);
            this.SquareSecondTextBox.TabIndex = 11;
            // 
            // SquareFirstTextBox
            // 
            this.SquareFirstTextBox.Location = new System.Drawing.Point(208, 48);
            this.SquareFirstTextBox.Name = "SquareFirstTextBox";
            this.SquareFirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.SquareFirstTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Введите вторую сторону:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Введите первую сторону:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 24);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Расчет периметра и площади прямоугольника";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CalculateTriangleButton);
            this.tabPage3.Controls.Add(this.TriangleHeightTextBox);
            this.tabPage3.Controls.Add(this.TriangleCoreSideTextBox);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.TriangleThirdTextBox);
            this.tabPage3.Controls.Add(this.TriangleSecondTextBox);
            this.tabPage3.Controls.Add(this.TriangleFirstTextBox);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(433, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Треугольник";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CalculateTriangleButton
            // 
            this.CalculateTriangleButton.Location = new System.Drawing.Point(12, 235);
            this.CalculateTriangleButton.Name = "CalculateTriangleButton";
            this.CalculateTriangleButton.Size = new System.Drawing.Size(90, 34);
            this.CalculateTriangleButton.TabIndex = 15;
            this.CalculateTriangleButton.Text = "Вычислить";
            this.CalculateTriangleButton.UseVisualStyleBackColor = true;
            this.CalculateTriangleButton.Click += new System.EventHandler(this.CalculateTriangleButton_Click);
            // 
            // TriangleHeightTextBox
            // 
            this.TriangleHeightTextBox.Location = new System.Drawing.Point(173, 181);
            this.TriangleHeightTextBox.Name = "TriangleHeightTextBox";
            this.TriangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.TriangleHeightTextBox.TabIndex = 14;
            // 
            // TriangleCoreSideTextBox
            // 
            this.TriangleCoreSideTextBox.Location = new System.Drawing.Point(173, 155);
            this.TriangleCoreSideTextBox.Name = "TriangleCoreSideTextBox";
            this.TriangleCoreSideTextBox.Size = new System.Drawing.Size(100, 20);
            this.TriangleCoreSideTextBox.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Введите высоту:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Введите величину основания:";
            // 
            // TriangleThirdTextBox
            // 
            this.TriangleThirdTextBox.Location = new System.Drawing.Point(149, 106);
            this.TriangleThirdTextBox.Name = "TriangleThirdTextBox";
            this.TriangleThirdTextBox.Size = new System.Drawing.Size(100, 20);
            this.TriangleThirdTextBox.TabIndex = 10;
            // 
            // TriangleSecondTextBox
            // 
            this.TriangleSecondTextBox.Location = new System.Drawing.Point(149, 77);
            this.TriangleSecondTextBox.Name = "TriangleSecondTextBox";
            this.TriangleSecondTextBox.Size = new System.Drawing.Size(100, 20);
            this.TriangleSecondTextBox.TabIndex = 9;
            // 
            // TriangleFirstTextBox
            // 
            this.TriangleFirstTextBox.Location = new System.Drawing.Point(149, 46);
            this.TriangleFirstTextBox.Name = "TriangleFirstTextBox";
            this.TriangleFirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.TriangleFirstTextBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Введите третью сторону:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Введите вторую сторону:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Введите первую сторону:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 24);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Расчет периметра и площади треугольника";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 303);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CalculateRoundButton;
        private System.Windows.Forms.TextBox RoundRadiusTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateSquareButton;
        private System.Windows.Forms.TextBox SquareSecondTextBox;
        private System.Windows.Forms.TextBox SquareFirstTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TriangleHeightTextBox;
        private System.Windows.Forms.TextBox TriangleCoreSideTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TriangleThirdTextBox;
        private System.Windows.Forms.TextBox TriangleSecondTextBox;
        private System.Windows.Forms.TextBox TriangleFirstTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CalculateTriangleButton;
    }
}

