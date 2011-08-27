using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class FerrariSpider : Car
    {
        double _cost = 250000;
        string _description = "Ferrari Spider";

        public override double Cost
        {
            get { return _cost; }
        }

        public override string Description
        {
            get { return _description; }
        }
    }
}
