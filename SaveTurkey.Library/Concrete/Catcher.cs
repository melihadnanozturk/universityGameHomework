//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Abstract;
using SaveTurkey.Library.Static;
using System;
using System.Drawing;

namespace SaveTurkey.Library.Concrete
{
    //özellikleri olacak
    class Catcher:PictureControl
    {
        public int score = 0;
        public string userName;
        public int bullets=0;
        public int vests=0;
        public int guns=0;
        public int soldier=0;
        public Catcher(int _movingSize,Size _panelSize) : base(_panelSize)
        {
            Center = _movingSize / 2;
            MovingSize = Width;
        }

        public bool Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    return MoveToRight();
                case Direction.LEFT:
                    return MoveToLeft();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        private bool MoveToRight()
        {
            if (Right == PanelSize.Width) return true;

            var newRight = Right + MovingSize;
            var isOverflow = newRight > PanelSize.Width;

            Right = isOverflow ? PanelSize.Width : newRight;

            return Right == PanelSize.Width;
        }

        private bool MoveToLeft()
        {
            if (Left == 0) return true;

            var newLeft = Left - MovingSize;
            var isOverflow = newLeft < 0;
            Left = isOverflow ? 0 : newLeft;

            return Left == 0;
        }
        public int calculateSoldier() {
            int dividBullet=0, dividGun=0,mostSmoll=0;
            if (vests!=0)
            {
                if (guns%2==0)
                {
                    dividGun = guns / 2;

                    if (bullets % 3 == 0)
                    {
                        dividBullet = bullets / 3;
                    }
                    mostSmoll = vests;
                    if (mostSmoll > dividGun)
                    {
                        mostSmoll = dividGun;
                    }
                    else if (mostSmoll > dividBullet)
                    {
                        mostSmoll = dividBullet;
                    }

                    soldier += mostSmoll;

                    calculateObject(mostSmoll);
                }
            }

            return soldier;
        }

        //DAHA SONRA HESAPLA SOLDİER
        /*
        public int askerHesapla()
        {
            if (vests!=0)
            {
                for (int i = vests; i > 0; i++)
                {
                    if (guns>=i*2)
                    {
                        if (guns/2==)
                        {

                        }
                    }
                    break;
                }
            }
        }*/

        private void calculateObject(int mostSmoll) {
            vests =vests - mostSmoll;
            guns = guns - (2 * mostSmoll);
            bullets = bullets - (3 * mostSmoll);
        }
    }
}
