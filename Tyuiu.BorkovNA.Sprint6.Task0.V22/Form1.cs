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
            catch { MessageBox.Show("�������� ������"); }
        }

        private void buttonWho_BNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-1 ������ ������� �������������");
        }
    }
}
