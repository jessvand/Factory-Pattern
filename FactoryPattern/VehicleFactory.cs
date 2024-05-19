using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfDoors)
        {
            switch (numberOfDoors)
            {
                case 0:
                     return new Motorcycle();
                case 2:
                    return new BigRig();
                case 4:
                    return new Cars();
                default:
                    return new Motorcycle(); 


            }       
        }
            


    }
    
        
    
}
