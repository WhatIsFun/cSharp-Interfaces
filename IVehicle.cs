using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_interface
{
    internal interface IVehicle
    {
        
        void Start();
        void Accelerate(int speed);
        void Brake();
    }
}
