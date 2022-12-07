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
            List<int> numbers = new List<int>();

            int A = -999, B = 999;

            for (int i = A; i <= B; i++)
            {
                if (Math.Abs(i).ToString().Length != 3) continue;
                numbers.Add(i);
            }

            string result = string.Empty;

            foreach(int num in numbers)
            {
                int abs_number = Math.Abs(num);

                int first = abs_number / 100;
                int second = abs_number % 100 / 10;
                int third = abs_number % 100 % 10;

                if (first == second || second == third || third == first)
                    result += num + " ";
            }

            MessageBox.Show($"Трехзначные числа, в которых хотя бы две цифры повторяются: {result}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
