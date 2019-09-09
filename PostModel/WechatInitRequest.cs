using StupidWehcat.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StupidWehcat.PostModel
{
    public class WechatInitRequest:MyBaseRequset,IBaseRequest<WechatInitResponse>
    {
        public WechatInitRequest(string uri)
        {
            base.Url = uri + "&fun=new&version=v2&lang=zh_CN";
            base.HttpMethod = HttpMethod.Get;
        }

        public HttpContent GetContent()
        {
            throw new NotImplementedException();
        }

        public HttpMethod GetHttpMethod() => base.HttpMethod;

        public WechatInitResponse GetResult(string content)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(content);
            XmlNode root = xmlDocument.SelectSingleNode("error");
            if (root.HasChildNodes) {

                WechatInitResponse result = new WechatInitResponse();
 
                XmlNode _ret = root.SelectSingleNode("ret");
                result.ret = int.Parse(_ret.InnerText);
                XmlNode _message = root.SelectSingleNode("message");
                result.message = _message.InnerText.ToString();
                XmlNode _skey = root.SelectSingleNode("skey");
                result.skey = _skey.InnerText.ToString();
                XmlNode _wxsid = root.SelectSingleNode("wxsid");
                result.wxsid = _wxsid.InnerText.ToString();
                XmlNode _wxuin = root.SelectSingleNode("wxuin");
                result.wxuin = _wxuin.InnerText.ToString() ;
                XmlNode _pass_ticket = root.SelectSingleNode("pass_ticket");
                result.pass_ticket = _pass_ticket.InnerText.ToString();
                return result;
            }
            return null;
        }

        public string GetUrl() => base.Url;
    }
}
