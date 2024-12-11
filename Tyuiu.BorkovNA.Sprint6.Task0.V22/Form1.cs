using Tyuiu.BorkovNA.Sprint6.Task0.V22.Lib;


namespace Tyuiu.BorkovNA.Sprint6.Task0.V22
{
    public partial class Form_BNA : Form
    {
        public Form_BNA()
        {
            InitializeComponent();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new();
                textBoxRes.Text = Convert.ToString(ds.Calculate(int.Parse(textBoxX.Text)));
            }
            catch { MessageBox.Show("Неверные данные"); }
        }

        private void buttonWho_BNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы Пктб-24-1 Борков Николай Александрович");
        }
    }
}
