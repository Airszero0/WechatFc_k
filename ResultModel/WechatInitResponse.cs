using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.ResultModel
{
    public class WechatInitResponse:MyBaseResponse
    {
        public int ret { get; set; }

        public string message { get; set; }


        public string skey { get; set; }

        public string wxsid { get; set; }

        public string wxuin { get; set; }

        public string pass_ticket { get; set; }

        public int isgrayscale { get; set; }
    }
}
