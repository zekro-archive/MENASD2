using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENASD_v2._0
{
    class Logger
    {

        public Logger()
        {
        }

        public void log(string content, string location = "log.log", bool noTimeStamp = false)
        {
            if (location == "" || location == null)
                return;

            string time = "[" + DateTime.Now + "]";
            System.IO.File.AppendAllText(location, noTimeStamp ? "" : time + " " + content + "\n");
            
        }
    }
}
