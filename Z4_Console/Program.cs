using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iteration = 0;
            int num = 3;
            int current_num = 0;

            for (int i = 11; i > 0; i--)
            {
                current_num = num;
                for (int j = i / 2; j > 0; j--)
                {
                    if (iteration % 2 != 0) Console.Write(current_num + " ");
                    else Console.Write("2 ");
                    current_num++;
                }
                
                if (iteration % 2 != 0) num--;
                iteration++;
                Console.WriteLine();
            }
        }
    }
}
