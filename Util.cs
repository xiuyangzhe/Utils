using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunyard.Common.Utils
{
    public class Util
    {
        /// <summary>
        /// set object Property
        /// </summary>
        /// <param name="_object"></param>
        /// <param name="fieldname"></param>
        /// <param name="fieldvalue"></param>
        public static void SetFieldValue(object _object, string fieldname, object fieldvalue)
        {
            try
            {
                _object.GetType().GetProperty(fieldname).SetValue(_object, fieldvalue, null);
            }
            catch (Exception message)
            {
                LogService.Debug(message);
            }
        }

        /// <summary>
        /// get object Property
        /// </summary>
        /// <param name="_object"></param>
        /// <param name="fieldname"></param>
        /// <returns></returns>
        public static Object GetFieldValue(object _object, string fieldname)
        {
            try
            {
                return _object.GetType().GetProperty(fieldname).GetValue(_object, null);
            }
            catch (Exception message)
            {
                LogService.Debug(message);
            }
            return null;
        }

    }
}
