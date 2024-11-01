using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class RadioActive : Container
    {
        private int _randMax;

        public RadioActive(int weight) : base (weight)
        {
            _randMax = 25;
        }
    }
}
