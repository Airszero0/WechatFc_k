using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.ResultModel
{
    public class LoginLoopResponse: MyBaseResponse
    {
        public LoginLoopResponse() { }

        public LoginLoopResponse(string url)
        {
            RedirectUri = url;
        }
        public string RedirectUri { get; set; }
    }
}
