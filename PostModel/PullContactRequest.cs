using StupidWehcat.ResultModel;
using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace StupidWehcat.PostModel
{
    public class PullContactRequest : MyBaseRequset, IBaseRequest<PullContactResponse>
    {
        public PullContactRequest() { }

        public PullContactRequest(string ticket,string skey)
        {
            base.Url = $"https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxgetcontact?lang=zh_CN&pass_ticket=" +
                ticket + "&r=" + CommonHelper.TimeSp_Stand13(DateTime.Now) + "&seq=0&skey=" + skey;
        }

        public HttpContent GetContent()
        {
            throw new NotImplementedException();
        }

        public HttpMethod GetHttpMethod() => HttpMethod.Get;

        public PullContactResponse GetResult(string content)
        {
            return JsonConvert.DeserializeObject<PullContactResponse>(content);
        }

        public string GetUrl() => base.Url;
      
    }
}
