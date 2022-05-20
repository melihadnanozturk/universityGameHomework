//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Static;
using System;

namespace SaveTurkey.Library.Interface
{
   internal interface IGame
    {
        event EventHandler GecenSureDegisti;

        void startGame();
        void stopAndResumeGame();
        void move(Direction direction);
        void controlToSoldier();

    }
}
