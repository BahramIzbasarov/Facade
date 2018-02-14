using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            PC pc = new PC();
            pc.GetInfo();
            
            pc.OnPC();
            pc.GetInfo();

            pc.OffPC();
            pc.GetInfo();
        }
    }
}
