﻿using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drones
{

    public partial class Building
    {
        private int _x;             //coordonnées x du building
        private int _y;             // coordonéées y du building
        private int _largeur = 25;
        private int _profondeur = 25;

        public int X { get => _x;}
        public int Y { get => _y;}
        public int Largeur { get => _largeur; }
        public int Profondeur { get => _profondeur; }
        public Building() 
        {
            _x = Helper.Random(0, AirSpace.WIDTH - 100);
            _y = Helper.Random(0, AirSpace.HEIGHT - 100);
        }
    }
}
