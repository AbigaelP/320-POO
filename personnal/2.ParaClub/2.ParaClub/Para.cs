using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ParaClub
{
    internal class Para
    {
        private string[] _withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
         };
        private string[] _withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
         };
        private string _name = "Bob";
        private int _x = 0;             //position x du parachutiste
        private int _y = 0;
        private int _taillePara = 6;

        //Méthode
        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            if ((_y == Config.SCREEN_HEIGHT - _taillePara) || (_y < Config.SCREEN_HEIGHT / 2))
            {
                for (int i = 0; i < _withoutParachute.LongLength; i++)
                {
                    Console.WriteLine(_withoutParachute[i]);
                }
            }
            else
            {
                for (int i = 0; i < _withParachute.LongLength; i++)
                {
                    Console.WriteLine(_withParachute[i]);
                }
            }
        }

        public void Update()
        {
            _y++;
            if (_y > Config.SCREEN_HEIGHT - _taillePara)
            {
                _y = Config.SCREEN_HEIGHT - _taillePara;
            }
        }
    }
}
