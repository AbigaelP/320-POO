﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    interface IDispatchable
    {
        void Register(Box newBox);

        void Delete(Box soldBox);

    }
}