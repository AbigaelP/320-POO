using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ParaClub
{
    class Program
    {
        static void Main(string[] args)
        {
           int y = Config.SCREEN_HEIGHT; //hauteur de l'écran
           int x = Config.SCREEN_WIDTH; //largeur de l'écran

            Console.SetWindowSize(x, y);
            
            //c'est mieux : Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT) 
            
            Plane plane = new Plane();

            plane.draw();

            Console.ReadLine();

       
        }
    }
}
