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
        static int lastId;
        private int _id;
        private int _time = Helper.Random(2, 11);
        public float PowerConsumption { get => _powerConsumption; set => _powerConsumption = value; }
        public int Id { get => _id; }

        public Factory()
        {
            _id = lastId + 1;
            lastId++;
            Console.WriteLine(_powerConsumption);
        }
    }
}
