//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ
using System.Windows.Forms;

namespace SaveTurkey
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Sağ Sol tuşları tutma kolu hareketi / 'P' oyun durdurma / Başlamak için 'ENTER'", "Oyun İçi Bilgilendirme");
            GameForm gameForm = new GameForm();//açılacak form
            gameForm.Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            FormScore formScore = new FormScore();
            formScore.Show();
        }
    }
}
