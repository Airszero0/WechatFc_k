using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StupidWehcat.ResultModel;

namespace StupidWehcat.PostModel
{
    public class CodeGenerateRequest : MyBaseRequset,IBaseRequest<CodeGenerateResponse>
    {
        public CodeGenerateRequest(string code)
        {
            base.Url = "https://login.weixin.qq.com/qrcode/" + code;
            base.HttpMethod = HttpMethod.Get;
        }
        public string GetUrl()
        {
            return base.Url;
        }
        public HttpMethod GetHttpMethod()
        {
            return base.HttpMethod;
        }

        public CodeGenerateResponse GetResult(string content)
        {
            Console.WriteLine(content);

            return new CodeGenerateResponse();

        }

        public HttpContent GetContent()
        {
            throw new NotImplementedException();
        }
    }

}
