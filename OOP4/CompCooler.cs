using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class CompCooler : Cooler
    {
        public CompCooler(ControPanel controPanel) : base(controPanel) { }

        public override void Changed()
        {
            base.Changed();
        }

        public override void IncreaseRPM(int i)
        {
            logger.Log("| Changing state of computer cooler... |");
            base.IncreaseRPM(i);
            logger.Log("| State of computer cooler has been changed |");
            Console.WriteLine("------------------------------------------");
        }

    }
}
