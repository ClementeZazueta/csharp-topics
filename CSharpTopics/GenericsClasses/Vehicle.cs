using System;

namespace GenericsClasses
{
    public class Vehicle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void Break()
        {
            Console.WriteLine("Slowing down");
        }

        public void Gas()
        {
            Console.WriteLine("Accelerating");
        }
    }
}
