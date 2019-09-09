using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.ResultModel
{
    public class MsgResponse:MyBaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseResponse BaseResponse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MsgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LocalID { get; set; }
    }
}
