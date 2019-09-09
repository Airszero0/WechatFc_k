using StupidWehcat.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.PostModel
{
    public class LoginLoopRequest : MyBaseRequset, IBaseRequest<LoginLoopResponse>
    {
        public LoginLoopRequest(string code)
        {
            base.HttpMethod = HttpMethod.Get;
            base.Url = "https://login.wx.qq.com/cgi-bin/mmwebwx-bin/login?loginicon=true&uuid="+ code + "&tip=0";
        }

        public HttpContent GetContent()
        {
            throw new NotImplementedException();
        }

        public HttpMethod GetHttpMethod()
        {
            return base.HttpMethod;
        }

        public LoginLoopResponse GetResult(string content)
        {
            string uri_content = content.TrimEnd(';').Split(';')[1];
            return new LoginLoopResponse(uri_content.Substring(uri_content.IndexOf('=')+1).Trim().Replace("\"",""));
        }

        public string GetUrl()
        {
            return base.Url;
        }
    }
}
