using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateRoundButton_Click(object sender, EventArgs e)
        {
            double radius = 0.0;

            try
            {
                radius = double.Parse(RoundRadiusTextBox.Text);

                if (radius <= 0) throw new Exception("Радиус окружности не может быть меньше или равен нулю!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Периметр круга равен: {2 * Math.PI * radius}, площадь круга равна: {Math.PI * radius * radius}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalculateSquareButton_Click(object sender, EventArgs e)
        {
            double side1 = 0.0;
            double side2 = 0.0;
            double side3 = 0.0;
            double side4 = 0.0;

            double w = 0.0, h = 0.0;

            try
            {
                side1 = double.Parse(SquareFirstTextBox.Text);
                side2 = double.Parse(SquareSecondTextBox.Text);
                side3 = double.Parse(SquareThirdTextBox.Text);
                side4 = double.Parse(SquareFourthTextBox.Text);

                w = double.Parse(SquareWidthTextBox.Text);
                h = double.Parse(SquateHeightTextBox.Text);

                if (side1 <= 0 || side2 <= 0 || side3 <= 0 || side4 <= 0)
                    throw new Exception("Стороны прямоугольника не могут быть меньше или равны нулю!");

                if (w <= 0 || h <= 0)
                    throw new Exception("Длина или ширина прямоугольника не могут быть меньше или равны нулю!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Периметр прямоугольника равен: {side1 + side2 + side3 + side4}, площадь треугольника равна: {h * w}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CalculateTriangleButton_Click(object sender, EventArgs e)
        {
            double side1 = 0.0;
            double side2 = 0.0;
            double side3 = 0.0;

            double core = 0.0;
            double height = 0.0;

            try
            {
                side1 = double.Parse(TriangleFirstTextBox.Text);
                side2 = double.Parse(TriangleSecondTextBox.Text);
                side3 = double.Parse(TriangleThirdTextBox.Text);

                core = double.Parse(TriangleCoreSideTextBox.Text);
                height = double.Parse(TriangleHeightTextBox.Text);
                
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                    throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");

                if (core <= 0 || height <= 0)
                    throw new Exception("Высота или основание треугольника не могут быть меньше или равны нулю!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Периметр треугольника равен: {side1 + side2 + side3}, площадь треугольника равна: {(core * height) / 2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
