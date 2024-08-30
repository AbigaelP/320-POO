using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Snail
{
    internal class Program
    {

        static void Main(string[] args)

        {
            //création d'une nouvelle liste
            List<Snail> snails = new List<Snail>();

            for (int i = 0; i < 10; i++)
            {
                snails.Add(new Snail(i));
            }

            Console.CursorVisible = false;

            while (snails[0].life > 0)
            {
                Console.Clear();
                foreach (Snail snail in snails)
                {
                    Console.SetCursorPosition(snail.x, snail.y);
                    Console.Write(snail.alive);
                    snail.Move();

                }
                Thread.Sleep(40);
            }

            foreach (Snail snail in snails)
            {
                Console.SetCursorPosition(snail.x, snail.y);
                Console.Write(snail.dead);
            }

            Console.ReadLine();
        }

    }
}
