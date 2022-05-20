//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Interface;
using SaveTurkey.Library.Static;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SaveTurkey.Library.Concrete
{
    //todo: oyun durumu ile pause durumu ayrılacak
    public class Game : IGame
    {
        #region Degiskenler
        private readonly Panel _arenaPanel;
        private readonly Panel _catcherPanel;
        private Catcher catcher;
        private Bullet bullet;
        private Gun gun;
        private ChangeBox changeBox;
        private BallisticVest ballisticVest;
        private Label _scoreLabel;
        private Label _gunLbl;
        private Label _bulletLbl;
        private Label _vestLbl;
        private Label _soldierLbl;
        public int falseLimit=0;
        private User user;
        private int wantedSoldier=0;
        private int wantedTime=0;
        private double zorluk = 0;
        #endregion

        #region Lists
        private readonly List<Gun> _guns = new List<Gun>();
        private readonly List<Bullet> _bullets= new List<Bullet>();
        private readonly List<BallisticVest> _ballisticVests= new List<BallisticVest>();
        private readonly List<ChangeBox> _changeBoxes = new List<ChangeBox>();
        #endregion

        #region Timers
        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _bulletOlusturmaTimer = new Timer { Interval = 2000 };
        private Timer _gunOlusturmaTimer = new Timer { Interval = 5000 };
        private readonly Timer _ballisticVestOlusturmaTimer = new Timer { Interval = 8000 };
        private readonly Timer _changeBoxOlusturmaTimer = new Timer { Interval = 15000 };
        #endregion

        #region Creaters
        private void CreateCatcher()
        {
            catcher = new Catcher(_catcherPanel.Width, _catcherPanel.Size);
            _catcherPanel.Controls.Add(catcher);
        }

        private void CreateBullet()
        {
            bullet = new Bullet(_arenaPanel.Size, zorluk);
            _bullets.Add(bullet);
            _arenaPanel.Controls.Add(bullet);
        }

        private void CreateGun()
        {
            gun = new Gun(_arenaPanel.Size, zorluk);
            _guns.Add(gun);
            _arenaPanel.Controls.Add(gun);
        }
        private void CreateBallisticVest()
        {
            ballisticVest = new BallisticVest(_arenaPanel.Size, zorluk);
            _ballisticVests.Add(ballisticVest);
            _arenaPanel.Controls.Add(ballisticVest);
        }
        private void CreateChangeBox()
        {
            changeBox = new ChangeBox(_arenaPanel.Size);
            _changeBoxes.Add(changeBox);
            _arenaPanel.Controls.Add(changeBox);
        }
        #endregion

        #region TickMethods
        private void BallisticVestOlusturma_Tick(object sender, EventArgs e)
        {
            CreateBallisticVest();
        }

        private void BulletOlusturma_Tick(object sender, EventArgs e)
        {
            CreateBullet();
        }

        private void GunOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            CreateGun();
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
            changeZorluk();
        }


        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            GunMoves();
            BulletMoves();
            BallisticVestMoves();
            ChangeBoxMoves();
        }

        private void ChangeBoxTimer_Tick(object sender,EventArgs e) {
            CreateChangeBox();
        }
        #endregion

        private TimeSpan _gecenSure;
        
        public GameState gameState=GameState.NOT_STARTER;

        public event EventHandler GecenSureDegisti;

        public TimeSpan GecenSure {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;
                GecenSureDegisti?.Invoke(this,EventArgs.Empty);
            }
        }

        public Game( Panel arenaPanel, Panel catcherPanel,Label scoreLabel,Label gunscore,Label bulletScore,Label vestScore,Label soldierLbl)
        {
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _gunOlusturmaTimer.Tick += GunOlusturmaTimer_Tick;
            _bulletOlusturmaTimer.Tick += BulletOlusturma_Tick;
            _ballisticVestOlusturmaTimer.Tick += BallisticVestOlusturma_Tick;
            _changeBoxOlusturmaTimer.Tick += ChangeBoxTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _arenaPanel = arenaPanel;
            _catcherPanel = catcherPanel;
            _scoreLabel = scoreLabel;
            _gunLbl = gunscore;
            _bulletLbl = bulletScore;
            _vestLbl = vestScore;
            _soldierLbl = soldierLbl;
        }

        public void changeZorluk() {
            double time = _gecenSure.TotalSeconds;

            if (time%15==0&& time !=0)
            {
                zorluk+=4;
            }
        }

        #region movesMethod
        private void GunMoves()
        {
            for (int i = _guns.Count - 1; i >= 0; i--)
            {
                var gun = _guns[i];
                var isHit = gun.MoveToDown();

                if (isHit)
                {
                    if (gun.Center < catcher.Right && gun.Center > catcher.Left)
                    {
                        changeZorluk();
                        catcher.score += gun.score;
                        catcher.guns++;
                        _gunLbl.Text = Convert.ToString(catcher.guns);
                        _scoreLabel.Text = Convert.ToString(catcher.score);
                        controlToSoldier();
                    }
                    else
                    {
                        checkFalseLimit();
                    }

                    _guns.Remove(gun);
                    _arenaPanel.Controls.Remove(gun);
                }
            }
        }

        private void BulletMoves()
        {
            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                var bullet = _bullets[i];
                var isHit = bullet.MoveToDown();

                if (isHit)
                {
                    if (isHit)
                    {
                        if (bullet.Center < catcher.Right && bullet.Center > catcher.Left)
                        {
                            catcher.score += bullet.score;
                            catcher.bullets++;
                            _bulletLbl.Text = Convert.ToString(catcher.bullets);
                            _scoreLabel.Text = Convert.ToString(catcher.score);
                            controlToSoldier();
                        }
                        else
                        {
                            checkFalseLimit();
                        }

                        _bullets.Remove(bullet);
                        _arenaPanel.Controls.Remove(bullet);
                    }
                }
            }
        }

        private void BallisticVestMoves()
        {
            for (int i = _ballisticVests.Count - 1; i >= 0; i--)
            {
                var ballisticVest = _ballisticVests[i];
                var isHit = ballisticVest.MoveToDown();

                if (isHit)
                {
                    if (isHit)
                    {
                        if (ballisticVest.Center < catcher.Right && ballisticVest.Center > catcher.Left)
                        {
                            catcher.score += ballisticVest.score;
                            catcher.vests++;
                            _vestLbl.Text = Convert.ToString(catcher.vests);
                            _scoreLabel.Text = Convert.ToString(catcher.score);
                            controlToSoldier();
                        }
                        else
                        {
                            checkFalseLimit();
                        }

                        _ballisticVests.Remove(ballisticVest);
                        _arenaPanel.Controls.Remove(ballisticVest);
                    }
                }
            }
        }

        private void ChangeBoxMoves()
        {
            for (int i = _changeBoxes.Count - 1; i >= 0; i--)
            {
                var changeBox= _changeBoxes[i];
                var isHit = changeBox.MoveToDown();
                
                if (isHit)
                {
                        if (changeBox.Center < catcher.Right && changeBox.Center > catcher.Left)
                        {
                        Random randomNumber = new Random();
                        int number = randomNumber.Next(4);

                        switch (number)
                        {
                            case 1:
                                stopTimers();
                                MessageBox.Show("+50 Cephe puan :D ");
                                catcher.score += 50;
                                _scoreLabel.Text = Convert.ToString(catcher.score);
                                break;
                            case 2:

                                stopTimers();
                                MessageBox.Show("Cephanede patlama... Bütün ekipmanlar yok oldu (Puanlarda gitti...)");
                                catcher.guns = 0;
                                catcher.vests = 0;
                                catcher.bullets = 0;
                                catcher.score = 0;
                                _scoreLabel.Text = Convert.ToString(catcher.score);
                                _gunLbl.Text = Convert.ToString(catcher.guns);
                                _bulletLbl.Text = Convert.ToString(catcher.bullets);
                                _vestLbl.Text = Convert.ToString(catcher.vests);
                                break;
                            case 3:

                                stopTimers();
                                MessageBox.Show("Cephede üstünlük kazandık, biraz yavaşlayabiliriz (Bütün cisimler yavaşladı)");
                                _bulletOlusturmaTimer.Interval = 4000;
                                _gunOlusturmaTimer.Interval = 7000;
                                _ballisticVestOlusturmaTimer.Interval = 10000;

                                break;
                            case 4:

                                stopTimers();
                                MessageBox.Show("İttifak tarafından hançer yedik. Şimdi daha fazla çalışma vakti.");
                                _bulletOlusturmaTimer.Interval = 1500;
                                _gunOlusturmaTimer.Interval = 3000;
                                _ballisticVestOlusturmaTimer.Interval = 7000;
                                break;
                        }
                    }

                        _changeBoxes.Remove(changeBox);
                        _arenaPanel.Controls.Remove(changeBox);
                }
            }
        }
        #endregion

        public void move(Direction direction)
        {
            catcher.Move(direction);
        }
        public void startGame()
        {
            Random randomTime = new Random();
            Random randomSoldier = new Random();
            wantedTime = randomTime.Next(50,120);
            wantedSoldier = randomSoldier.Next(1,10);
            MessageBox.Show("Soldier : "+wantedSoldier.ToString()+" / Şu zamana kadar : "+wantedTime.ToString(),"İstenilenler");
            startTimer();
            CreateCatcher();
        }

        public void stopAndResumeGame()
        {
            if (gameState == GameState.CONTINUE)
            {
                stopTimers();
                MessageBox.Show("Oyun duraklatıldı");
            }
            else if (gameState == GameState.GAME_PAUSED)
            {
                startTimer();
            }
        }

        public void checkFalseLimit() {
            if (falseLimit==7)
            {
                stopTimers();
                MessageBox.Show("Yeterince askeri disipline sahip değilsin,7 tane cisim tutamadın, git çalış ve cepheye öyle destek ver...");
                gameState = GameState.FINISHED;
            }

            falseLimit++;
        }

        private void startTimer() {

            _gecenSureTimer.Start();
            _hareketTimer.Start();
            _gunOlusturmaTimer.Start();
            _bulletOlusturmaTimer.Start();
            _ballisticVestOlusturmaTimer.Start();
            _changeBoxOlusturmaTimer.Start();
            gameState = GameState.CONTINUE;
        }

        private void stopTimers()
        {
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
            _gunOlusturmaTimer.Stop();
            _bulletOlusturmaTimer.Stop();
            _ballisticVestOlusturmaTimer.Stop();
            _changeBoxOlusturmaTimer.Stop();
            gameState = GameState.GAME_PAUSED;
        }

        public void controlToSoldier()
        {
            _soldierLbl.Text = Convert.ToString(catcher.calculateSoldier());

            if (catcher.soldier!=null && wantedSoldier==catcher.soldier)
            {
                stopTimers();
                MessageBox.Show("Yeterince asker topladık.Savaşı kazandık aferim asker...");

                user = new User("deneme", catcher.score);
                saveScoreAndUser();
            }
        }



        private void saveScoreAndUser() {

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter streamWriter = File.AppendText(path + @"\topFiveScore.txt"))
            {
                streamWriter.WriteLine(user.score);
            }
        }
    }
}
