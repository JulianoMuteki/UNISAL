using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class CarOption : Car
    {
        private double _cost = -1;
        private string _desc = "abstract car option.";

        public override double Cost
        {
            get { return _cost; }
        }

        public override string Description
        {
            get { return _desc; }
        }
    }
}
