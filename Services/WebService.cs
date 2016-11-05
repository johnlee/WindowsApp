using System.IO;
using System.Net;
using System.Text;

namespace Services
{
    public static class WebService
    {
        // Given a url, does a simple webrequest and returns the response as string
        public static string GetWebResponse(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                return "ERROR during web request! " + ex.Message;
            }
        }
    }
}
