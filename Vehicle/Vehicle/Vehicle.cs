using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Vehicle
    {
        public string brand;
        public int topSpeed;

        public Vehicle(string Brand, int TopSpeed)
        {
            brand = Brand;
            topSpeed = TopSpeed;
        }

        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is driving!");
        }
    }

    class Car : Vehicle
    {
        public Car(string Brand, int TopSpeed) : base(Brand, TopSpeed) { }

        public override void Drive()
        {
            Console.WriteLine("The car is drivng!");
        }
    }

    class Bike : Vehicle
    {
        public Bike(string Brand, int TopSpeed) : base (Brand, TopSpeed) { }
        public override void Drive()
        {
            Console.WriteLine("The bike is driving!");
        }
    }

    class Truck : Vehicle 
    {
        public Truck(string Brand, int TopSpeed) : base (Brand, TopSpeed) { }
        public override void Drive()
        {
            Console.WriteLine("The truck is driving!");
        }
    }

}
