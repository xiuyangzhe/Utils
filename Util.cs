﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunyard.Common.Utils
{
    public class Util
    {
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
    }
}