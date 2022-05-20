//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using System;
using System.IO;
using System.Windows.Forms;

namespace SaveTurkey
{
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }

        private void FormScore_Activated(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter streamWriter = File.AppendText(path + @"\topFiveScore.txt"))
            {

            }

            string[] saved = File.ReadAllLines(path + @"\topFiveScore.txt");

            for (int i = 0; i < saved.Length; i++)
            {
                listBox1.Items.Add(saved[i]);
            }
        }
    }
}
