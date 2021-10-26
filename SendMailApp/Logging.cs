using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp
{
    public class Logging
    {
        //Text file logging
        public static void LoggingText(Exception ex)
        {
            File.AppendAllText("log.txt", Environment.UserName + " " + Environment.MachineName);
            File.AppendAllText("log.txt", Environment.NewLine);
            File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            File.AppendAllText("log.txt", "\r\n");
            File.AppendAllText("log.txt", ex.Message);
            File.AppendAllText("log.txt", ex.StackTrace);
            File.AppendAllText("log.txt", Environment.NewLine + "*******************************" + Environment.NewLine);
        }
    }
}
