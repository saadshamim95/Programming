using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Functional
{
    class StopWatch
    {
        public void simulate() {
            /*Console.Write("Press Enter to Start!");
            Console.ReadLine();
            int start = DateTime.Now.Second;
            Console.Write("Press Enter to Stop!");
            Console.ReadLine();
            int stop = DateTime.Now.Second;
            int elapsedTime = stop - start;
            Console.WriteLine("Time Elapsed: "+elapsedTime);*/

            Stopwatch watch = new Stopwatch();
            Console.WriteLine("Press Enter to start!");
            Console.ReadLine();
            watch.Start();
            Console.WriteLine("Press Enter to stop!");
            Console.ReadLine();
            watch.Stop();
            Console.Write("Elapsed Time: {0:hh\\:mm\\:ss}", watch.Elapsed);
        }
    }
}
