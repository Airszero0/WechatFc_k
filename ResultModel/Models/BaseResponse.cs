using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.ResultModel.Models
{
    public class BaseResponse
    {
        public string Ret { get; set; }

        public string ErrMsg { get; set; }
    }
}
