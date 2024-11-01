using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class Bateau
    {
        //Attributs
        private int _year;
        private const int TONNAGE = 1000;
        private string _country;
        private int _weight;
        public List<Container> flotte = new List<Container>();

        //Propriété
        public int Weight { get => _weight; set => _weight = value; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Bateau()
        {
            _weight = 0;
        }
        public bool Load(Container container) 
        {
            flotte.Add(container);
            return true;
        }
        public bool Unload(Container id)
        {
            if (!flotte.Contains(id)) return false;
            flotte.Remove(id);
            return true;
        }
    }
}
