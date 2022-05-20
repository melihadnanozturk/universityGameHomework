//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Abstract;
using System;
using System.Drawing;

namespace SaveTurkey.Library.Concrete
{
    class Gun: PictureControl
    {

        public int score = 2;

        private static readonly Random Random = new Random();

        public Gun(Size sizeOfPanel,double deger) : base(sizeOfPanel)
        {
            MovingSize = (int)(Height * .3+deger);
            Left = Random.Next(sizeOfPanel.Width - Width + 1);
        }
    }
}
