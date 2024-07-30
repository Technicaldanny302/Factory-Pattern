using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int WheelCount)
        {
           switch (WheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new ThreeWheeler();
                case 4:
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
