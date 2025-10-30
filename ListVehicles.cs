using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class ListVehicles
    {

        public static List<ObjectVehicle> vehicles = [];

        public static void AddVehicle(ObjectVehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
    }
}
