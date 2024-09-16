using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        private float _powerConsumption = 17F;

        public float PowerConsumption { get => _powerConsumption; set => _powerConsumption = value; }

        public Factory()
        {
            
            Console.WriteLine(_powerConsumption);
        }
    }
}
