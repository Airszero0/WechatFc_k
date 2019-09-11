using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.ResultModel
{
    public class PullContactResponse: MyBaseResponse
    {
        public List<MemberListItemForPullContact> MemberList { get; set; }

        public BaseResponse BaseResponse { get; set; }

        public int MemberCount { get; set; }

        public int Seq { get; set; }
    }

    public class MemberListItemForPullContact
    {
        /// <summary>
        /// 
        /// </summary>
        public int Uin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 橘老师限定版
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HeadImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ContactFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MemberCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RemarkName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HideInputBarFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 不定期推送，目标不是教你如何挣得面包，而是使每一口都更加香甜。
        /// </summary>
        public string Signature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int VerifyFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OwnerUin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PYInitial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PYQuanPin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RemarkPYInitial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RemarkPYQuanPin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StarFriend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AppAccountFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Statues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AttrStatus { get; set; }
        /// <summary>
        /// 浙江
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 嘉兴
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @Alias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SnsFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UniFriend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ChatRoomId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string KeyWord { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EncryChatRoomId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsOwner { get; set; }
    }
}
