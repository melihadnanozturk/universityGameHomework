//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Static;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTurkey.Library.Abstract
{
    class Substance:PictureControl
    {
        public Substance(Size sizeOfPanel) : base(sizeOfPanel)
        {
        }

        public bool Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    return MoveToLeft();
                case Direction.LEFT:
                    return MoveToRight();
                default:
                    throw new ArgumentOutOfRangeException(null);
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
    }
}
