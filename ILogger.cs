using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_interface
{
    internal interface ILogger
    {
        void LogInfo(string message);
        void LogError(string errorMessage);

    }
}
