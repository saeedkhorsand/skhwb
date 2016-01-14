using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using SKHWB.BPerformanceTools;
namespace SKHWB.webCrackingTools
{
    public abstract class WebPostLogin :ComplexCleanupBase
    {
        public CookieAwareWebClient client = new CookieAwareWebClient();
        public NameValueCollection Values { get; set; }
        public string Url { get; set; }

        public WebPostLogin() { }
        public WebPostLogin(string Url, NameValueCollection Values)
        {
            this.Values = Values;
            this.Url = Url;
        }
        public string fSendPostRequest(string Url,NameValueCollection values)
        {
            return System.Text.Encoding.UTF8.GetString(client.UploadValues(Url, values));
        }
        public string fSendPostRequest()
        {
            return System.Text.Encoding.UTF8.GetString(client.UploadValues(Url, Values));
        }

        public override bool fCleanUp()
        {
            this.client.Dispose();
            return true;
        }
    }
}
