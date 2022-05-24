using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class DecoratorCooler : Part
    {
        public DecoratorCooler(ControPanel controPanel) : base(controPanel) { }

        public override void Changed()
        {
            base.Changed();
        }
    }
}
