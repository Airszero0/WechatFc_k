using StupidWehcat.ResultModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidWehcat.ResultModel
{
    public class InitResponse:MyBaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseResponse BaseResponse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ContactListItem> ContactList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SyncKey SyncKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ChatSet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ClientVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SystemTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GrayScale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int InviteStartCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MPSubscribeMsgCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MPSubscribeMsgListItem> MPSubscribeMsgList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ClickReportInterval { get; set; }
    }

    public class BaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public int Ret { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ErrMsg { get; set; }
    }

    public class MemberListItem
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
        /// 
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AttrStatus { get; set; }
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
        public int MemberStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string KeyWord { get; set; }
    }

    public class ContactListItem
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
        /// 文件传输助手
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
        public List<MemberListItem> MemberList { get; set; }
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
        /// 
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
        /// 
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 
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

    public class ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int Key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Val { get; set; }
    }

    public class SyncKey
    {
        /// <summary>
        /// 
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ListItem> List { get; set; }
    }

    public class User
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
        /// 要涂黑
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HeadImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RemarkName { get; set; }
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
        public int HideInputBarFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StarFriend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Signature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AppAccountFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int VerifyFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ContactFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int WebWxPluginSwitch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HeadImgFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SnsFlag { get; set; }
    }

    public class MPArticleListItem
    {
        /// <summary>
        /// 杠杆资金在路上！两融扩标刚满三周，吸引511亿资金涌入，三类题材最受追捧！券商融券业务也意外火了
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 券商中国微信号：quanshangcn
        /// </summary>
        public string Digest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
    }

    public class MPSubscribeMsgListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MPArticleCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MPArticleListItem> MPArticleList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// 券商中国
        /// </summary>
        public string NickName { get; set; }
    }
}
