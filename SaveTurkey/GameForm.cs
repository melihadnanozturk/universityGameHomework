//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Concrete;
using SaveTurkey.Library.Static;
using System;
using System.Windows.Forms;

namespace SaveTurkey
{
    public partial class GameForm : Form
    {

        private readonly Game game;
        public GameForm()
        {
            InitializeComponent();
            game = new Game(arenaPanel, catcherPanel, scoreLabel, gunScoreLbl, bulletScoreLbl, vestScoreLbl, soldierLbl);
            game.GecenSureDegisti += Game_GecenSureDegisti;
        }

        //todo: oyun devam
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (game.gameState == GameState.NOT_STARTER && e.KeyCode != Keys.Enter)
            {
                MessageBox.Show("Oyun daha başlamadı. Başlamak için ENTER a basınız");
            }
            else if (game.gameState == GameState.FINISHED) 
            {
                FormScore formScore = new FormScore();
                formScore.Show();
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (game.gameState == GameState.NOT_STARTER)
                        {
                            game.startGame();
                        }
                        break;
                    case Keys.Right:
                        game.move(Direction.RIGHT);
                        break;
                    case Keys.Left:
                        game.move(Direction.LEFT);
                        break;
                    case Keys.P:
                        game.stopAndResumeGame();
                        break;
                }
            }
        }

        private void Game_GecenSureDegisti(object sender, EventArgs e)
        {
            label1.Text = game.GecenSure.ToString(@"m\:ss");
        }
    }
}
