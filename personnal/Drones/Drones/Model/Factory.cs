using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drones.Helpers;

namespace Drones
{
    public partial class Factory : Building
    {
        private float _powerConsumption = 17F;
        static int lastId;
        private int _id;
        private int _count = 60;
        public float PowerConsumption { get => _powerConsumption; set => _powerConsumption = value; }
        public int Id { get => _id; }

        public Factory()
        {
            _id = lastId + 1;
            lastId++;
            Console.WriteLine(_powerConsumption);
        }
        public void Update()
        {
            //insérer un compteur de frame
            _count = _count - 1;
            if (_count == 0)
            {
                if (Helper.Random(1, 2) == 1)
                {
                    Console.WriteLine("Un boite a été crée par l'usine" + Id);
                }
                _count = 60;
            }
        }
    }
}
