using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = @"Log4net.config", Watch = true)]
namespace mmw.Common
{
    /// <summary>
    /// log4net调用类
    /// </summary>
    public class LogHelper
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Fatal(string message, Exception exception)
        {
            _log.Fatal(message, exception);
        }

        public static void Error(string message, Exception exception)
        {
            _log.Error(message, exception);
        }

        public static void Error(string message)
        {
            _log.Error(message);
        }

        public static void Warn(string message)
        {
            _log.Warn(message);
        }

        public static void Info(string message)
        {
            _log.Info(message);
        }

        public static void Debug(string message)
        {
            _log.Debug(message);
        }
    }
}
