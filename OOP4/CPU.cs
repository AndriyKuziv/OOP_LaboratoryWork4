using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class CPU : Part
    {
        public CPU(ControPanel controPanel) : base(controPanel) { }

        private double clock = 3.2;
        private double temp = 70;

        //public void ShowTemp()
        //{
        //    Console.WriteLine("Temperature(C): " + temp);
        //}

        //public void ShowClock()
        //{
        //    Console.WriteLine("Clock speed(GHz): " + clock);
        //}

        public void SetTemp()
        {
            Console.Write("Temperature(C): ");
            temp = Convert.ToInt32(Console.ReadLine());

            Changed();
        }

        public void DecreaseTemp(int i)
        {
            logger.Log("Decreasing temperature of CPU...");
            temp -= i;
            logger.Log("CPU temperature has been decreased. CPU temperature now - " + temp + "C");
        }

        public bool canDecreaseClock()
        {
            if (clock > 1.5) return true;
            return false;
        }

        public void DecreaseClock(int i)
        {
            logger.Log("Decreasing clock speed of CPU...");
            clock -= i;
            logger.Log("CPU clock speed has been decreased. CPU clock speed now - " + clock + "GHz");
            DecreaseTemp(i * 5);
        }

        public double GetTemp()
        {
            return temp;
        }
        public double GetClock() { 
            return clock; 
        }
    }
}
