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
        static readonly ILog Log = LogManager.GetLogger(typeof(T));

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
      
        public static void LogException(Exception exception)
        {

            Log.Info("***************************Exception****************************");
            Log.Info(System.Environment.NewLine);
            Log.Error(Convert.ToString(exception.Message));
            Log.Info(Convert.ToString(exception.StackTrace));
            Log.Info(System.Environment.NewLine);
            Log.Info("****************************************************************");
        }
        
        public static void LogInfo(string message)
        {
            Log.Info(message);
        }
       
        public static void LogDateAndTime(DateTime dateTime)
        {
            Log.Info(dateTime.ToLongDateString());
        }
    }
}
