using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.DataBase
{
    public class Words
    {
        private static string strlen = "sb|傻逼|你身披麻戴，头顶锅盖，|脑残|白痴|你一生下来就被驴踢，脑袋像坨屎|就你长着那酷似菊花的脸，别人想爆还需要闭上双眼|你就像一个在超市里面买菜的一个大妈|操你妈，日子那么难过像被人强奸了，但是经典他妈说与其挣扎不如学会享受|怪只怪我太年轻，是人是狗都分不清|你两岁死爹，三岁死妈|野种儿子，滚去吃屎";
        public static List<string> phy {
            get {
                return strlen.Split('|').ToList();
            }
        }
    }
}
