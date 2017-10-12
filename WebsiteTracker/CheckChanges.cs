using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebsiteTracker
{
    static class CheckChanges
    {
        public static string GetResult(string content, string start, string stop)
        {
            if (content == "Updating content...") return "";
            if (start == "") start = "^";
            if (stop == "") stop = "$";

            Match m = Regex.Match(content, start + "(.*?)" + stop, RegexOptions.Singleline);
            return m.Groups[1].Value.Trim();
        }

        public static string GetChecksum(string content, string start, string stop)
        {
            string result = GetResult(content, start, stop);
            if (result != "") return CreateMD5(result);
            else return "";
        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public static string GetSource(string address)
        {
            try
            {
                using (MyWebClient wc = new MyWebClient())
                {
                    wc.Proxy = null;
                    wc.Headers.Add("Content-Type", "text/html; charset=UTF-8");
                    Stream data = wc.OpenRead(address);
                    StreamReader reader = new StreamReader(data);
                    return reader.ReadToEnd();
                }
            }

            catch
            {
                return "";
            }
        }

    }

    class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = 15 * 1000;
            return w;
        }
    }

}
