using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class Container
    {
        //Attributs
        private int _id = 0;
        protected int weight;
        //Propriété
        public int Id { get => _id;}
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="weight"></param>
        public Container(int weight) 
        {
            this._id++;
            this.weight = weight;
        }
    }
}
