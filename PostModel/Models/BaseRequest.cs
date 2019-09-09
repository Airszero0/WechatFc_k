using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.PostModel.Models
{
    public class BaseRequest
    {
        public BaseRequest() { }

        public string Uin { get; set; }

        public string Sid { get; set; }

        public string Skey { get; set; }

        public string DeviceID {
            get{
                return "e" + GetRandomStr(15);
            }
        }

        private string GetRandomStr(int len)
        {
            string result = "";
            Random random = new Random();
           
            for (int i=0; i<len;i++)
            {
                byte[] buffer = Guid.NewGuid().ToByteArray();
                int iSeed = BitConverter.ToInt32(buffer, 0);
                random = new Random(iSeed);
                result = result + random.Next(0, 9).ToString();
            }
            return result;
        }
    }
}
