using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class ObjectVehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }
        public string? Color { get; set; }
        public string? CarWash { get; set; }
        public string? Wheels { get; set; }

        public ObjectVehicle (string brand, string model, string year, string color, string carWash, string wheels)
        {
            string Brand = brand;
            string Model = model;
            string Year = year;
            string Color = color;
            string CarWash = carWash;
            string Wheels = wheels;


        }
        
    }
}
