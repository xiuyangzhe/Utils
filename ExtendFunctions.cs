using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zsq.Utils
{
    public static class ExtendFunctions
    {
        public static Int32 ToInt32(this string value)
        {
            Int32 i = 0;
            int.TryParse(value, out i);
            return i;
        }

        public static Int16 ToInt(this Boolean value)
        {
            if (value)
                return 1;
            else
                return 0;
        }

        public static bool IsNullOrEmpty(this string inputvalue)
        {
            return string.IsNullOrEmpty(inputvalue);
        }

        public static bool IsNotNullOrEmpty(this string inputvalue)
        {
            return !string.IsNullOrEmpty(inputvalue);
        }

        public static double ToDouble(this string inputvalue)
        {
            Double d = 0.00;
            double.TryParse(inputvalue, out d);
            return d;
        }

        public static bool ToBoolean(this string inputvalue)
        {

            if (inputvalue.ToLower() == "true")
                return true;
            if (inputvalue.ToLower() == "false")
                return false;
            if (inputvalue.ToLower() == "1")
                return true;
            if (inputvalue.ToLower() == "0")
                return false;
            if (inputvalue.ToLower() == "1")
                return true;
            return false;
        }

        public static string IsNulltoString(this object inputvalue)
        {
            var value = "";
            if (inputvalue != null)
                value = inputvalue.ToString();
            return value;
        }
    }
}
