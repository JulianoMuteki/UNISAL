using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
   public class OptionLeather: CarOption
    {
        double _cost = 1000;
        string _description = "Leather Seats, ";
        Car _car;

        public OptionLeather(Car car)
        {
            _car = car;
        }

        public override double Cost
        {
            get
            {
                return _car.Cost + _cost;
            }
        }

        public override string Description
        {
            get
            {
                return _car.Description + _description;
            }
        }

    }
}
