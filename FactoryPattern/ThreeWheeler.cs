using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialouge();
            Console.WriteLine("Lets get going");
        }
    }
}
