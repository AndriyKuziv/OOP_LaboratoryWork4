using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class CPUFan : Cooler
    {
        public CPUFan(ControPanel controPanel) : base(controPanel) { }

        public override void Changed()
        {
            base.Changed();
        }

        public override void IncreaseRPM(int i)
        {
            logger.Log("| Changing state of CPU fan... |");
            base.IncreaseRPM(i);
            logger.Log("| State of CPU fan has been changed |");
            Console.WriteLine("----------------------------------------");

        }
    }
}
