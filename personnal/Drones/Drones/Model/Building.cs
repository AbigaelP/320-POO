using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Building
    {
        private int _x;             //coordonnées x du building
        private int _y;             // coordonéées y du building
        private int _largeur = 100;
        private int _profondeur =100;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Largeur { get => _largeur; }
        public int Profondeur { get => _profondeur; }
    }
}
