using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StupidWehcat
{
    public class WechatHttpClient<T,K> 
        where K : IBaseRequest<T>
        where T : MyBaseResponse
    {
        public static readonly HttpClient httpClient = new HttpClient();

        private K Request;

        public WechatHttpClient(K _request)
        {
            Request = _request;
        }

        public Byte[] DoImageGet()
        {
            byte[] bys = httpClient.GetByteArrayAsync(Request.GetUrl()).Result;
            return bys;
        }

        public T DoGet()
        {
            HttpResponseMessage responseMessage = null;
            responseMessage = httpClient.GetAsync(Request.GetUrl()).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                T result = Request.GetResult(responseMessage.Content.ReadAsStringAsync().Result);
                result.StatusCode = responseMessage.StatusCode;
                return result;
            }
            return default(T);
        }

        public T DoPost()
        {
            HttpResponseMessage httpResponseMessage = null;
            //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
            httpResponseMessage = httpClient.PostAsync(Request.GetUrl(), Request.GetContent()).Result;
            if (httpResponseMessage.IsSuccessStatusCode) {
                T result = Request.GetResult(httpResponseMessage.Content.ReadAsStringAsync().Result);
                result.StatusCode = httpResponseMessage.StatusCode;
                return result;
            }
            return default(T);
        }
    }
}
