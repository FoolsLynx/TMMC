using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;

namespace TMMC
{
    public static class TMMCUtils
    {
        internal static ILog Logger = LogManager.GetLogger("TMMC");

        public static void Log(string message)
        {
            Logger.Debug("[TMMC] " + message);
        }

        public static void Log(object message, params object[] formatData)
        {
            Log(string.Format(message.ToString(), formatData));
        }
    }
}
