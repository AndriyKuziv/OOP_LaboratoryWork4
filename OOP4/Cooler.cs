using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Cooler : DecoratorCooler
    {
        public Cooler(ControPanel controPanel) : base(controPanel) { }


        private int maxrpm = 2000;
        private int rpm = 500;
        private int rpmInterval = 100;

        public int GetRPM()
        {
            return rpm;
        }
        public int GetMaxRPM()
        {
            return maxrpm;
        }

        public int GetInterval()
        {
            return rpmInterval;
        }

        public bool canIncrease()
        {
            if (rpm != maxrpm) return true;
            return false;
        }

        public virtual void IncreaseRPM(int i)
        {
            logger.Log("Increasing RPM of fan...");
            if (rpm < maxrpm)
            {
                rpm += i;
                logger.Log("RPM has been increased");
                if (rpm > maxrpm)
                {
                    rpm = maxrpm;
                    logger.Log("Warning! cooler has reached its limit!");
                }
            }
            else
            {
                logger.Log("Fan is already at limit of its possibilities");
            }

            Changed();
        }
        //public void DecreaseRPM(int i)
        //{
        //    logger.Log("Decreasing the speed of fan...");
        //    if (rpm > 200)
        //    {
        //        rpm -= i;
        //        logger.Log("Speed of fan has been decreased. Enjoy more quiet computer! (Speed of cooler now: " + rpm + " RPM)");
        //    }
        //    else logger.Log("For God's sake, you want your CPU to melt?!");
        //    Changed();
        //}
    }
}
