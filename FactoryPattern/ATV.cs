using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ATV : IVehicle
    {
        public ATV()
        {

        }
        public void Drive()
        {
            Console.WriteLine("The ATV is riding through trails so fast.");
        }
    
    
    
    }
}
