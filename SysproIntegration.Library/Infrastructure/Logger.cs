using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Infrastructure
{
    public class Logger<T>
    {
        static readonly ILog iLog = LogManager.GetLogger(typeof(T));

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
      
        public static void LogException(Exception exception)
        {

            iLog.Info("***************************Exception****************************");
            iLog.Info(System.Environment.NewLine);
            iLog.Error(Convert.ToString(exception.Message));
            iLog.Info(Convert.ToString(exception.StackTrace));
            iLog.Info(System.Environment.NewLine);
            iLog.Info("****************************************************************");
        }
        
        public static void LogInfo(string message)
        {
            iLog.Info(message);
        }
       
        public static void LogDateAndTime(DateTime dateTime)
        {
            iLog.Info(dateTime.ToLongDateString());
        }
    }
}
