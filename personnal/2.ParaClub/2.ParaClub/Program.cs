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
            Para para = new Para();


            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
                

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();
                para.Draw();

                // Temporiser
                Thread.Sleep(100);

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
  
                            break;
                        case ConsoleKey.Enter:
                            Environment.Exit(0);
                            break;
                    }
                }
            }



            //Console.ReadLine();


        }
    }
}
