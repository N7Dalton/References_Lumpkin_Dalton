using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Lumpkin_Dalton
{
    internal interface IAutomobile
    {
        double Speed { get; }
        int Wheels { get; }
        string LicensePlate { get; }

        public void Stringify() { }
    }
}
