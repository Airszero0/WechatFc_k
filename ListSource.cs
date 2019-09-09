using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat
{
    public class ListSource
    {
        public ListSource() { }

        public ListSource(string userName, string nickName)
        {
            UserName = userName;
            NickName = nickName;
        }

        public string UserName { get; set; }

        public string NickName { get; set; }
    }
}
