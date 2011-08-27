using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class OptionTurbo : CarOption
    {
        double _cost = 7000.24;
        string _description = "Turbo, ";
        Car _car;

        public OptionTurbo(Car car)
        {
            _car = car;
        }

        public override double Cost
        {
            get { return _car.Cost + _cost; }
        }

        public override string Description
        {
            get { return _car.Description + _description; }
        }
    }
}
