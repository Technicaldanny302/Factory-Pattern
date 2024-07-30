using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public class Car()
        {
        }                   
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialouge();
            Console.WriteLine("The Car is driving at a safe pace. Woooo!");
           
        }
    }
}
