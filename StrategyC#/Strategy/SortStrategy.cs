﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
   public abstract class SortStrategy
    {
       public abstract void Sort(List<string> list);
    }
}
