using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Part
    {
        private readonly ControPanel _controPanel;

        public Logger logger = new Logger();
        public Part(ControPanel controPanel)
        {
            _controPanel = controPanel;
        }
        public virtual void Changed()
        {
            _controPanel.SomethingChanged(this);
        }
    }
}
