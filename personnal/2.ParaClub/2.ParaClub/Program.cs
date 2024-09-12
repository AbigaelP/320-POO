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
                plane.Update();
                

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.Draw();

                // Temporiser
                Thread.Sleep(100);

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Spacebar:
                            plane.Add();
                            
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }
            }



            //Console.ReadLine();


        }
    }
}
