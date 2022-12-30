using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;


namespace countdown
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("time");
        }

        protected override  void Run()
        {
            DateTime dt = DateTime.Now;
            DateTime dt2 = new DateTime(2023,1,1,0,0,0);
            long dt3 = dt2.Ticks-dt.Ticks;
            TimeSpan elapsedSpan = new TimeSpan(dt3);
            dt3 = (dt3 / (1800));

            Console.WriteLine(elapsedSpan.TotalSeconds + "seconds...");
            Console.Write("Input: ");
            Thread.Sleep(1000);


        }
    }
}
