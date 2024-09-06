using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ParaClub
{
    internal class Para
    {
        private string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
         };
        private string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
         };  
        private string name = "Bob";

        int x = 0;  //position y du parachutiste

        public void Draw()
        {
            int y = 0;

            for (int i = 0; i < withoutParachute.LongLength; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(withoutParachute[i]);
                y++;
            }
        }



    }
}
