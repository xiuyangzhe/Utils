using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zsq.Utils
{
    public sealed class JsonTool
    {
        public static string Obj2Json(object _object)
        {
            try
            {
                return JsonConvert.SerializeObject(_object); ;
            }
            catch
            {
                return null;
            }
        }
        public static Object Json2Obj(String json)
        {
            try
            {
                return JsonConvert.DeserializeObject(json);
            }
            catch(Exception ex)
            {
                LogService.Error(ex);
                return null;
            }
        }

        public static JObject JsonToObj(string json)
        {
            try
            {
                return JObject.Parse(json);
            }
            catch { return null; }
        }
    }
}
