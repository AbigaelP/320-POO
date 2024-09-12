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
        private int _taillePara = 7;
        private bool _chute = false;

        public int X { get => _x; set => _x = value; }

        //Méthode
        public void Draw()
        {

            if ((_y == Config.SCREEN_HEIGHT - _taillePara) || (_y < Config.SCREEN_HEIGHT / 2))
            {
                for (int i = 0; i < _withoutParachute.LongLength; i++)
                {
                    Console.SetCursorPosition(_x, _y+i);
                    Console.WriteLine(_withoutParachute[i]);
                }
            }
            else
            {
                for (int i = 0; i < _withParachute.LongLength; i++)
                {
                    Console.SetCursorPosition(_x, _y+i);
                    Console.WriteLine(_withParachute[i]);
                }
                _chute = true;
            }
        }

        public void Update()
        {
            if (_chute)
            {
                _y++;
            }
            else 
            {
                _y += 3;
            }
            
            if (_y > Config.SCREEN_HEIGHT - _taillePara)
            {
                _y = Config.SCREEN_HEIGHT - _taillePara;
            }
        }
    }
}
