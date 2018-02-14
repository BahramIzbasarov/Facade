using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PC
    {
        Facade.VideoCard VC = new VideoCard();
        Facade.RAM RAM = new RAM();
        Facade.PowerSupply PS = new PowerSupply();
        Facade.OpticalDiskDrive ODD = new OpticalDiskDrive();
        Facade.Sensors S = new Sensors();
        Facade.Winchester W = new Winchester();

        public void OnPC()
        {
            VC.PoweredOn = true;
            RAM.PoweredOn = true;
            PS.PoweredOn = true;
            ODD.PoweredOn = true;
            S.PoweredOn = true;
            W.PoweredOn = true;

        }

        public void OffPC()
        {
            VC.PoweredOn = false;
            RAM.PoweredOn = false;
            PS.PoweredOn = false;
            ODD.PoweredOn = false;
            S.PoweredOn = false;
            W.PoweredOn = false;
        }

        public void GetInfo()
        {
            Console.WriteLine(VC.GetInfo());
            Console.WriteLine(RAM.GetInfo());
            Console.WriteLine(PS.GetInfo());
            Console.WriteLine(ODD.GetInfo());
            Console.WriteLine(S.GetInfo());
            Console.WriteLine(W.GetInfo());
        }
    }
}
