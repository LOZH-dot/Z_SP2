using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            double x0 = 0, y0 = 0;

            double x1 = 0, x2 = 0, x3 = -23;
            double y1 = 0, y2 = 23, y3 = 23;

            double a = 0, b = 0, c = 0;

            try
            {
                x0 = double.Parse(XTextBox.Text);

                y0 = double.Parse(YTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

            if (a == 0 || b == 0 || c == 0)
                MessageBox.Show("Точка находится на границе", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (a > 0 && b > 0 && c > 0)
                MessageBox.Show("Точка находится внутри", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Точка находится снаружи", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
