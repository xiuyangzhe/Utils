using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Sunyard.Common.Utils
{
    public class FileOperation
    {
        public static string ReadFile(string path)
        {
            var myStr = string.Empty;
            try
            {

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    int fsLen = (int)fs.Length;
                    byte[] heByte = new byte[fsLen];
                    int r = fs.Read(heByte, 0, heByte.Length);
                    myStr = System.Text.Encoding.UTF8.GetString(heByte);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return myStr;
        }

        public static bool WriteFile(string path, string linestr)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter _writer = new StreamWriter(fs))
                {
                    _writer.WriteLine();
                    _writer.Write(linestr);
                    _writer.Flush();
                    return false;
                }
            }
        }
        public static bool WriteFile(string path, byte[] bytes)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(bytes);
                    return true;
                }
            }

        }
    }
}