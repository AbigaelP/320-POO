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
        private int _x = 0;             //position y du parachutiste
        private int _y = 0;

        //Méthode
        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            for (int i = 0; i < _withoutParachute.LongLength; i++)
            {
                Console.WriteLine(_withoutParachute[i]);
            }
        }

        public void Update()
        {
            _y++;
            if (_y >= 33)
            {
                _y = 33;
            }
        }
    }
}
