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

            if (Math.Abs(x0) < y0 && x0 < 0 && x0 > -23 && y0 < 23 && y0 > 0)
                MessageBox.Show("Точка находится внутри", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (x0 > y0 || y0 < 0 || y0 > 23)
                MessageBox.Show("Точка находится снаружи", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Точка находится на границе", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
