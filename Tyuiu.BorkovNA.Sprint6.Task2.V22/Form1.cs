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
            try
            {
                DataService ds = new();
                double[] res = ds.GetMassFunction(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text));
                for (int i = 0; i < res.Length; i++)
                {
                    dataGridView1.Rows.Add(int.Parse(textBoxA.Text) + i, res[i]);
                }
            }
            catch
            {
                MessageBox.Show("�������� ������");
            }
        }

        private void buttonWho_BNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 �������� ������� ������ ����-24-1 ������ ������� �������������");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
