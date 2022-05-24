using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class ControPanel
    {
        Logger logger = Logger.GetInstance();

        public int maxTemp = 75;

        public ControPanel()
        {
            CreateParts();
        }

        private void CreateParts()
        {
            cpu = new CPU(this);
            cpufan = new CPUFan(this);
            cooler = new CompCooler(this);
        }

        public CPU cpu { get; private set; }
        public Cooler cpufan { get; private set; }

        public Cooler cooler { get; private set; }

        public void Set()
        {
            Console.Write("Maximum temperature(C): ");
            maxTemp = Convert.ToInt32(Console.ReadLine());
            Console.Write("How much RPM will be changed in one time: ");
        }

        public void SomethingChanged(Part part)
        {
            switch (part)
            {
                case CPU:
                    double t = cpu.GetTemp();
                    while (t >= maxTemp)
                    {
                        if (cpufan.canIncrease())
                        {
                            cpufan.IncreaseRPM(cpufan.GetInterval());
                        }
                        else if (cpu.canDecreaseClock())
                        {
                            cpu.DecreaseClock(1);
                        }
                        else break;
                        t = cpu.GetTemp();
                    }
                    logger.Log("We've done everything we can with it right now");
                    break;
                case CompCooler:

                    break;
                case CPUFan:
                    int rpm = cpufan.GetRPM();
                    int maxrpm = cpufan.GetMaxRPM();
                    cpu.DecreaseTemp(cpufan.GetInterval() / 20);
                    break;
            }
        }
    }
}
