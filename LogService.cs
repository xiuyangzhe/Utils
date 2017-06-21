using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sunyard.Common.Utils
{
    public sealed class LogService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(LogService));

        public static void Debug(object message)
        {
            Log.Debug(message);
        }

        public static void DebugFormatted(string format, params object[] args)
        {
            Log.DebugFormat(CultureInfo.InvariantCulture, format, args);
        }

        public static void Info(object message, bool filterFlag = false)
        {
            if (filterFlag)
                return;
            Log.Info(message);
        }

        public static void InfoFormatted(string format, params object[] args)
        {
            Log.InfoFormat(CultureInfo.InvariantCulture, format, args);
        }

        public static void Warn(object message, bool filterFlag = false)
        {
            if (filterFlag)
                return;
            Log.Warn(message);
        }

        public static void Warn(object message, Exception exception)
        {
            Log.Warn(message, exception);
        }

        public static void WarnFormatted(string format, params object[] args)
        {
            Log.WarnFormat(CultureInfo.InvariantCulture, format, args);
        }

        public static void Error(object message, bool filterFlag = false)
        {
            if (filterFlag)
                return;
            Log.Error(message);
        }

        public static void Error(object message, Exception exception, bool filterFlag = false)
        {
            if (filterFlag)
                return;
            Log.Error(message, exception);
        }

        public static void ErrorFormatted(string format, params object[] args)
        {
            Log.ErrorFormat(CultureInfo.InvariantCulture, format, args);
        }

        public static void Fatal(object message)
        {
            Log.Fatal(message);
        }

        public static void Fatal(object message, Exception exception)
        {
            Log.Fatal(message, exception);
        }

        public static void FatalFormatted(string format, params object[] args)
        {
            Log.FatalFormat(CultureInfo.InvariantCulture, format, args);
        }

        public static bool IsDebugEnabled
        {
            get
            {
                return Log.IsDebugEnabled;
            }
        }

        public static bool IsInfoEnabled
        {
            get
            {
                return Log.IsInfoEnabled;
            }
        }

        public static bool IsWarnEnabled
        {
            get
            {
                return Log.IsWarnEnabled;
            }
        }

        public static bool IsErrorEnabled
        {
            get
            {
                return Log.IsErrorEnabled;
            }
        }

        public static bool IsFatalEnabled
        {
            get
            {
                return Log.IsFatalEnabled;
            }
        }
    }
}
