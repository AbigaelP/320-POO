using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Snail
{
    internal class Snail
    {
        public int life = 50;               //point de vie
        public int x = 0;                   //position de l'axe x
        public int y = 0;                   //position de l'axe y
        public string alive = "_@_ö";       //visuel de l'escargot vivant
        public string dead = "____";        //visuel de l'escargot mort
        public string name;                 //nom de l'escargot

        //Constructeur
        public Snail(int y)
        {
            this.y = y;
            this.name = "escargot" + y;
        }

        public Snail()
        {
            y = 12;
            this.name = "Escargot";
        }

        //Méthodes
        public void Move()
        {
            x++;
            life--;      //un déplacement coûte un point de vie
        }

    }
}
