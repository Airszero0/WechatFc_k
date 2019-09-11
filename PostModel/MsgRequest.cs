using StupidWehcat.PostModel.Models;
using StupidWehcat.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StupidWehcat.PostModel
{
    public class MsgRequest : MyBaseRequset, IBaseRequest<MsgResponse>
    { 
        private MsgData Data { get; set; }

        public MsgRequest(string ticket, MsgData data)
        {
            base.Url = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxsendmsg?lang=zh_CN&pass_ticket=" + ticket;
            Data = data;
        }
        public HttpContent GetContent()
        {
            return new StringContent(JsonConvert.SerializeObject(Data));
        }

        public HttpMethod GetHttpMethod() => HttpMethod.Post;

        public MsgResponse GetResult(string content)
        {
            return JsonConvert.DeserializeObject<MsgResponse>(content);
        }

        public string GetUrl() => base.Url;
    }

    public class MsgData
    {
        public int Scene => 0;

        public Msg Msg { get; set; }

        public BaseRequest BaseRequest { get; set; }

    }


    public class Msg {
        public int Type { get; set; }

        public string Content { get; set; }

        public string FromUserName { get; set; }

        public string ToUserName { get; set; }

        public string LocalID => CommonHelper.TimeSp_Len17(DateTime.Now);

        public string ClientMsgId => this.LocalID;

        public string MediaId { get; set; }   
      
    }
}
