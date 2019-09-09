using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat
{
    public interface IBaseRequest<Result>
    {
        Result GetResult(string content);

        string GetUrl();

        HttpMethod GetHttpMethod();

        HttpContent GetContent();
    }
}
