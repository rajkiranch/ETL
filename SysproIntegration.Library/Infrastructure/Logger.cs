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
        /// 
        /// </summary>
        /// <param name="exception"></param>
        public static void LogException(Exception exception)
        {

            iLog.Info("***************************Exception****************************");
            iLog.Info(System.Environment.NewLine);
            iLog.Error(Convert.ToString(exception.Message));
            iLog.Info(Convert.ToString(exception.StackTrace));
            iLog.Info(System.Environment.NewLine);
            iLog.Info("****************************************************************");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void LogInfo(string message)
        {
            iLog.Info(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        public static void LogDateAndTime(DateTime dateTime)
        {
            iLog.Info(dateTime.ToLongDateString());
        }
    }
}
