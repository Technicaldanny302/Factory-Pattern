using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialouge()
        {
            Console.WriteLine("Put key in ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Constructing build kit");
            Thread.Sleep(1000);
        }
    }
}
