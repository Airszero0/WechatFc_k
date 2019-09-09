using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.ResultModel
{
    public class JsLoginResponse: MyBaseResponse
    {
        public JsLoginResponse() { }
        public JsLoginResponse(string code)
        {
            Code = code;
        }
        public string Code { get; set; }
    }
}
