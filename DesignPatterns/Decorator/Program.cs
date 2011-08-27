using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos nosso carro
            Car car = new FerrariSpider();

            //decorá-lo com a opção de couro
            car = new OptionLeather(car);

            //decorá-lo com a opção de jantes de liga leve
            car = new OptionAlloyWheels(car);

            //decorá-lo com a opção turbo
            car = new OptionTurbo(car);

            Console.WriteLine("Description-->" + car.Description.TrimEnd(' ', ','));
            Console.WriteLine("Cost-->" + car.Cost.ToString());
            Console.ReadLine();
        }
    }
}
