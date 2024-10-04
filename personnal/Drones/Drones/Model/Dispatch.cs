using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch : IDispatchable
    {
        List<Box> boxes = new List<Box>();

        public void Delete(Box soldBox)
        {
            throw new NotImplementedException();
        }

        public void Register(Box newBox)
        {
            throw new NotImplementedException();
        }
    }
}
