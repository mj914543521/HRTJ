using System;
using System.Collections.Generic;
using System.Text;
using FW.Config;
using log4net;

namespace Com.cn.Log
{
    internal sealed class LoggingManager
    {
        
        static LoggingManager()
        {
            try
            {
                log4net.Config.XmlConfigurator.ConfigureAndWatch(
                    new System.IO.FileInfo(
                        PathHelper.GetAbsolutePath(ConfigManager.GetAppConfig("Common.LogConfig")))
                    );
            }
            catch
            {
                
            }
        }

        private LoggingManager()
        {
        }

        public static ILog GetLogger(string name)
        {
            return LogManager.GetLogger(name);
        }
    }
}
