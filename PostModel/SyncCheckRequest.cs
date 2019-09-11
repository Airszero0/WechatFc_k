using StupidWehcat.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.PostModel
{
    public class SyncCheckRequest : MyBaseRequset, IBaseRequest<SyncCheckResponse>
    {

        public SyncCheckRequest(string skey,string sid,string uin,string synckey)
        {

        }

        public HttpContent GetContent()
        {
            throw new NotImplementedException();
        }

        public HttpMethod GetHttpMethod() => HttpMethod.Get;

        public SyncCheckResponse GetResult(string content)
        {
            throw new NotImplementedException();
        }

        public string GetUrl() => base.Url;
    }
}
