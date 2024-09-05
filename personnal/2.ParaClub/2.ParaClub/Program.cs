using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.ParaClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT); 
            
            Plane plane = new Plane();


            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
                

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }

            //Console.ReadLine();

       
        }
    }
}
