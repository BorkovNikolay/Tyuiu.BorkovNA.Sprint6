using Tyuiu.BorkovNA.Sprint6.Task3.V29.Lib;

namespace Tyuiu.BorkovNA.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            int[,] input = { { -2, -13, -15, -9, -17 }, { 13, -20, -15,  27,  18 }, { -12, -1, -20,  13,   0 }, { 15,  32,  18, -12, -18 }, { 16,   5,   3, -5, -8 } };
            int[,] dsr = ds.Calculate(input);
            for (int i = 0; i < 5; i++)
            {
                GridRes.Rows.Add(dsr[i, 0], dsr[i, 1], dsr[i, 2], dsr[i, 3], dsr[i, 4]);
            }
        }

        private void buttonWho_BNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы Пктб-24-1 Борков Николай Александрович");
        }
    }
}
