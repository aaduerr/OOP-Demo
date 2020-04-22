// Written by Andrew Duerr
// Following the tutorials at PluralSight.com
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach(var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
