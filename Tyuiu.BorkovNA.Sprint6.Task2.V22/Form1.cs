using Tyuiu.BorkovNA.Sprint6.Task2.V22.Lib;

namespace Tyuiu.BorkovNA.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            
            DataService ds = new();
            int start = Convert.ToInt32(textBoxA.Text);
            int end = Convert.ToInt32(textBoxB.Text);

            int len = ds.GetMassFunction(start, end).Length;

            double[] value = new double[len];

            value = ds.GetMassFunction(start, end);

            for (int i = 0; i < len; i++)
            {
                this.dataGridView1.Rows.Add(Convert.ToString(start), Convert.ToString(value[i]));
                start++;
            }
        }
    }
}
