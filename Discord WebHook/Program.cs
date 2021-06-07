using System.Collections.Specialized;
using System.Net;

namespace Discord_WebHook
{
    class Program
    {
        static void Main()
        {
            Post("WEBHOOK URL HERE", new NameValueCollection()
            {
                {"username","USERNAME HERE"},
                {"avatar_url","AVATAR URL HERE"},
                {"content","CONTENT HERE"},
            });
        }

        public static byte[] Post(string post, NameValueCollection nameValueCollection)
        {
            using (WebClient webClient = new WebClient()) return webClient.UploadValues(post, nameValueCollection);
        }
    }
}
