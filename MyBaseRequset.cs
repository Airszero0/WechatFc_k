using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace StupidWehcat
{
    public class MyBaseRequset
    {
        public string Url { get; set; }

        public HttpMethod HttpMethod { get; set; }

        public HttpContent Content { get; set; }

    }
}
