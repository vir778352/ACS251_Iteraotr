﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
