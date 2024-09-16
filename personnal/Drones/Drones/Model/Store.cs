using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private List <string> _openingHours = new List<string> { "Lundi: 8h-18h", "Mardi: 8h-18h", "Mercredi: 8h-18h" };

        public Store() 
        {
            foreach (string horaire in _openingHours)
            { 
             Console.WriteLine(horaire);
            }
        }

    }
}
