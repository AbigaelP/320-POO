using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class Fridge : Container
    {
        private int _temperature;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="weight"></param>
        public Fridge(int weight) : base(weight)
        {
            _temperature = 8;
        }
    }
}
