//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using System.Drawing;
using System.Windows.Forms;

namespace SaveTurkey.Library.Abstract
{
    class PictureControl:PictureBox
    {
        public Size PanelSize { get; }
        public int MovingSize { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        protected PictureControl(Size sizeOfPanel)
        {
            Image = Image.FromFile($@"{GetType().Name}.png");
            PanelSize = sizeOfPanel;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public bool MoveToDown()
        {

            if (Bottom == PanelSize.Height) return true;

            var newBottom = Bottom + MovingSize;
            var isOverflow = newBottom > PanelSize.Height;

            Bottom = isOverflow ? PanelSize.Height : newBottom;

            return Bottom == PanelSize.Height;
        }
    }
}
