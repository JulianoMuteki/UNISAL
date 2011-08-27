using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
  public abstract class Car:ICar
    {
       private double _cost = -1;
       private string _desc = "abstract car.";

        public virtual double Cost
        {
            get { return _cost; }
        }

        public virtual string Description
        {
            get { return _desc; }
        }
    }
}
