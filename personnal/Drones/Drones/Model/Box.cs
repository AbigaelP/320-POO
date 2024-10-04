using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drones.Helpers;

namespace Drones
{
    public enum SmartiesColor
    {
        Inconnu,
        Rouge,
        Jaune,
        Brun,
        Orange
    }
    public class Box
    {
        static int lastNumber;
        private int _number;
        private int _kilo = Helper.Random(5, 11);
        private SmartiesColor _color = SmartiesColor.Inconnu;

        public int Kilo { get => _kilo; }
        public int Number { get => _number; }

        public Box()
        {
            _number = lastNumber + 1;
            lastNumber++;
        }
    }
}
