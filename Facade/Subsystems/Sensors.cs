using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Sensors
    {
        private bool poweredOn;
        public bool PoweredOn
        {
            get => poweredOn;
            set => poweredOn = value;
        }

        public bool GetInfo()
        {
            return poweredOn;
        }
    }
}
