using Tyuiu.BorkovNA.Sprint6.Task1.V16.Lib;

namespace Tyuiu.BorkovNA.Sprint6.Task1.V16
{
    public partial class FormMain_BNA : Form
    {
        public FormMain_BNA()
        {
            InitializeComponent();
        }

        private void buttonWho_BNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы Пктб-24-1 Борков Николай Александрович");
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new();
                double[] result = ds.GetMassFunction(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text));
                textBoxRes.AppendText("+---------------+" + Environment.NewLine);
                textBoxRes.AppendText("|   X   |  F(x) |" + Environment.NewLine);
                textBoxRes.AppendText("+---------------+" + Environment.NewLine);
                for (int i = 0; i < result.Length; i++)
                {
                    string s = string.Format("|{0,5:d}  | {1,5:f2} |", i + int.Parse(textBoxA.Text), result[i]);
                    textBoxRes.AppendText(s + Environment.NewLine);
                }
                textBoxRes.AppendText("+---------------+\n");
            }
            catch { MessageBox.Show("неверные данные"); }
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
