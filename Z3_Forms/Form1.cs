using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string[] strs = NumbersTextBox.Text.Split(' ');
            string result = string.Empty;

            foreach(string str in strs)
            {
                int number = 0;

                try
                {
                    number = int.Parse(str);
                }
                catch
                {
                    continue;
                }

                int abs_number = Math.Abs(number);

                int first = abs_number / 100;
                int second = abs_number % 100 / 10;
                int third = abs_number % 100 % 10;

                if (first == second || second == third || third == first)
                    result += str + " ";
            }

            MessageBox.Show($"Трехзначные числа, в которых хотя бы две цифры повторяются: {result}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
