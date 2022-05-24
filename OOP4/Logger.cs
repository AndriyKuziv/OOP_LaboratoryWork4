using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOP4
{
    class Logger
    {
        private static int count = 0;
        private static Logger instance = null;

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string l)
        {
            Thread.Sleep(300);
            Console.WriteLine("#" + count + ": " + l);
            count++;
        }
    }
}
