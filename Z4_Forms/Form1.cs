namespace Z4_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            int iteration = 0;
            int num = 3;
            int current_num = 0;

            for (int i = 11; i > 0; i--)
            {
                current_num = num;
                for (int j = i / 2; j > 0; j--)
                {
                    if (iteration % 2 != 0) result += current_num + " ";
                    else result += "2 ";
                    current_num++;
                }

                if (iteration % 2 != 0) num--;
                iteration++;
                result += "\n";
            }

            MessageBox.Show(result);
        }
    }
}