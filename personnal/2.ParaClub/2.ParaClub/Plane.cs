using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ParaClub
{
    internal class Plane
    {
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        int x = 0; //position sur l'axe x



        //methode

        public void update()
        {
            x++;

            if (x == Config.SCREEN_WIDTH)
            {
                x = 0;
            }

        }

        public void draw()
        {
            int y = 0;

            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(view[i]);
                y++;
            }
        }
    }
}
