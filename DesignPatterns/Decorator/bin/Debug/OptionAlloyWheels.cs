using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
   public class OptionAlloyWheels : CarOption
    {
        double _cost = 4564.42;
        string _description = "Alloy Wheels, ";
        Car _car;

        public OptionAlloyWheels(Car car)
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
