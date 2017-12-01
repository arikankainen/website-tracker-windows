using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebsiteTracker
{
    static class CheckChanges
    {
        public static string GetChecksum(string content, string start, string stop)
        {
            string result = GetResult(content, start, stop);
            if (result != "") return CreateMD5(result);
            else return "";
        }

        public static string GetResult(string content, string start, string stop)
        {
            if (content == "Updating content...") return "";

            start = Regex.Escape(start);
            stop = Regex.Escape(stop);

            if (start == "") start = "^";
            if (stop == "") stop = "$";

            Match m = Regex.Match(content, start + "(.*?)" + stop, RegexOptions.Singleline);
            return m.Groups[1].Value.Trim();
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
                    wc.Encoding = Encoding.UTF8;
                    wc.Proxy = null;

                    wc.Headers.Add("Content-Type", "text/html; charset=UTF-8");
                    wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36 OPR/48.0.2685.35");
                    wc.Headers.Add("Accept-Encoding", "gzip, deflate");
                    wc.Headers.Add("Accept-Language", "en-US,en;q=0.8");

                    Stream data = wc.OpenRead(address);
                    StreamReader reader = new StreamReader(data);

                    string str = reader.ReadToEnd();
                    return Regex.Replace(str, @"[\0|\00]", "");  // remove NULL characters
                }
            }

            catch (WebException ex)
            {
                return "[ERROR]" + ex.Message;
            }
        }

    }

    //class MyWebClient : WebClient
    //{
    //    protected override WebRequest GetWebRequest(Uri uri)
    //    {
    //        // for error: The request was aborted: Could not create SSL/TLS secure channel.
    //        ServicePointManager.Expect100Continue = true;
    //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

    //        WebRequest w = base.GetWebRequest(uri);
    //        w.Timeout = 30 * 1000;
    //        return w;
    //    }
    //}

    class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            // for error: The request was aborted: Could not create SSL/TLS secure channel.
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var request = base.GetWebRequest(uri) as HttpWebRequest;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            request.Timeout = 30 * 1000;
            return request;
        }
    }

}
