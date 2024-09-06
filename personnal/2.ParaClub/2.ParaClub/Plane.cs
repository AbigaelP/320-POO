using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ParaClub
{
    internal class Plane
    {
        private string[] _view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        private int _x = 0; //position sur l'axe x

        //methode
        public void Update()
        {
            _x++;
            if (_x == Config.SCREEN_WIDTH)
            {
                _x = 0;
            }
        }

        public void Draw()
        {
            int y = 0;
            for (int i = 0; i < _view.Length; i++)
            {
                Console.SetCursorPosition(_x, y);
                Console.WriteLine(_view[i]);
                y++;
            }
        }
    }
}
