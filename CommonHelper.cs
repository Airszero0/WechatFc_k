using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat
{
    public class CommonHelper
    {
        public static string TimeSp_Len9(DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            string t = (time.Ticks - startTime.Ticks).ToString();
            return t.Substring(t.Length - 9);
        }

        public static string TimeSp_Len17(DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (time.Ticks - startTime.Ticks) / 10000;
            return t.ToString() + GetRandomStr(4);
        }

        public static string TimeSp_Stand13(DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = (time.Ticks - startTime.Ticks) / 10000;
            return t.ToString();
        }

        public static string GetRandomStr(int len)
        {
            string result = "";
            Random random = new Random();
            for (int i = 0; i < len; i++)
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
