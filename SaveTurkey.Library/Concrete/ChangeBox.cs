//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Abstract;
using System;
using System.Drawing;

namespace SaveTurkey.Library.Concrete
{
    class ChangeBox : PictureControl
    {
        private static readonly Random Random = new Random();

        public ChangeBox(Size sizeOfPanel) : base(sizeOfPanel)
        {
            MovingSize = (int)(Height * .5);
            Left = Random.Next(sizeOfPanel.Width - Width + 1);
        }

    }
}
