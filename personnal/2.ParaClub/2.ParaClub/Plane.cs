using System;
using System.CodeDom;
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

        private List<Para> _parachutistes = new List<Para>();


        //methode
        public void Update()
        {
            _x++;
            if (_x == Config.SCREEN_WIDTH)
            {
                _x = 0;
            }
            foreach (Para para in _parachutistes)
            {
                para.Update();
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
            foreach (Para para in _parachutistes)
            {
                para.Draw();
            }
        }

        public void Add()
        {
            Para para = new Para();
            para.X = _x;
            _parachutistes.Add(para);
        }
    }
}
