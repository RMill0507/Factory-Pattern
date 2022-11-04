using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int seatCount)
        {
            switch (seatCount)
            {
                case 6:
                    return new Truck();
                case 2:
                    return new ATV();
                case 5:
                    return new Car();
                default:
                    return new Car();

            }
        }
    }
}
