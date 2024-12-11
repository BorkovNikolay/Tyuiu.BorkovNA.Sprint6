using Tyuiu.BorkovNA.Sprint6.Task4.V22.Lib;

namespace Tyuiu.BorkovNA.Sprint6.Task4.V22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V22.txt");
                File.WriteAllText(path, textBoxRes.Text);

                DialogResult dialogResult = MessageBox.Show("Ôàéë " + path + " ñîõðàíåí óñïåøíî!\n Îòêðûòü åãî â áëîêíîòå? ", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèè ôàéëà ", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {

        }
    }
}
