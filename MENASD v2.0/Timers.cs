using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;

namespace MENASD_v2._0
{
    class Timers
    {
        
        static Timer ameRunning = new Timer();

        public static void ameRunning_start()
        {
            ameRunning.Elapsed += new ElapsedEventHandler(ameRunning_onTick);
            ameRunning.Interval = 1000;
            ameRunning.Start();
        }

        private static void ameRunning_onTick(object source, ElapsedEventArgs e)
        {
            Process[] p = Process.GetProcessesByName("Adobe Media Encoder");

            if (p.Length > 0)
            {
                Main.test = 1;
            }
        }

    }
}
