//MELİH ADNAN ÖZTÜRK
//B201200019
//NDP DÖNEM SONU PROJE ÖDEVİ

using SaveTurkey.Library.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTurkey.Library.Concrete
{
    class User :UserInterface
    {
        public int score;


        public User(string _name,int _score) {
            score = _score;
        }
        public void saveScore(User user)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter streamWriter = File.AppendText(path + @"\scores.txt"))
            {
                streamWriter.WriteLine(Convert.ToString(user.score));
            }
        }
    }
}
