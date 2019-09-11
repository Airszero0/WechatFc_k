using StupidWehcat.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using StupidWehcat.PostModel.Models;

namespace StupidWehcat.PostModel
{
    public class InitPostModel : MyBaseRequset, IBaseRequest<InitResponse>
    {
        public class PostData {
            public PostData(BaseRequest data)
            {
                BaseRequest = data;
            }
            public BaseRequest BaseRequest;
        }

        private PostData postData;



        public InitPostModel(string ticket, BaseRequest request)
        {

            base.Url = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxinit?r=-" + CommonHelper.TimeSp_Len9(DateTime.Now) + "&pass_ticket=" + ticket;
            postData = new PostData(request);
        }
        public HttpContent GetContent()
        {
            return new StringContent(JsonConvert.SerializeObject(postData));
        }

        public HttpMethod GetHttpMethod() => HttpMethod.Post;

        public InitResponse GetResult(string content)
        {
            return JsonConvert.DeserializeObject<InitResponse>(content);
        }

        public string GetUrl() => base.Url;
    }
}
