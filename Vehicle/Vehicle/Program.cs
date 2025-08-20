using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Ford", 120);
            Bike bike = new Bike("Yamaha", 160);
            Truck truck = new Truck("Mercedes", 110);

            car.Drive();
            bike.Drive();
            truck.Drive();
        }
    }
}
