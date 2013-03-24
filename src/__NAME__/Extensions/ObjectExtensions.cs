using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using log4net;

namespace System
{
    public static class ObjectExtensions
    {
        public static void Info(this object obj, string message)
        {
            var logger = LogManager.GetLogger(obj.GetType().ToString());
            if (logger.IsInfoEnabled)
            {
                logger.Info(message);
            }
        }
    }
}