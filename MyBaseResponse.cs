using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat
{
    public class MyBaseResponse
    {
        public HttpStatusCode StatusCode { get; set; }

        public string Msg { get; set; }
    }
}
