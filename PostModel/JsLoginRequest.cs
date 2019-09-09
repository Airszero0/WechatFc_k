using StupidWehcat.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.PostModel
{
    public class JsLoginRequest : MyBaseRequset,IBaseRequest<JsLoginResponse>
    {
        public JsLoginRequest() {
            base.Url = "https://login.wx.qq.com/jslogin?appid=wx782c26e4c19acffb&fun=new&lang=zh_CN";
            base.HttpMethod = HttpMethod.Get;
        }

        public HttpContent GetContent()
        {
            throw new NotImplementedException();
        }

        public HttpMethod GetHttpMethod()
        {
            return base.HttpMethod;
        }

        public JsLoginResponse GetResult(string content)
        {
            string[] array = content.TrimEnd(';').Split(';');

            string code = array[1].Substring(array[1].IndexOf('=')+1).Trim().Replace("\"","");
            return new JsLoginResponse(code);
        }

        public string GetUrl()
        {
            return base.Url;
        }
    }
}
