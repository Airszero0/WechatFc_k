using StupidWehcat.PostModel;
using StupidWehcat.ResultModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using StupidWehcat.PostModel.Models;
using StupidWehcat.DataBase;
using System.Threading;

namespace StupidWehcat
{
    public partial class Form1 : Form
    {

        private string loginCode;

        private string authUrl;

        private string skey;

        private string wxsid;

        private string wxuin;

        private string pass_ticket;

        private string user_name;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            RefushCode();
            textBox4.Text = "10";

            int index = 1;
            foreach (var item in Words.phy)
            {
                keyValuePairs.Add(index,item);
                index++;
            }
        }

        private void RefushCode()
        {
            WechatHttpClient<JsLoginResponse, JsLoginRequest> wechatHttpClient = new WechatHttpClient<JsLoginResponse, JsLoginRequest>(new JsLoginRequest());
            loginCode = wechatHttpClient.DoGet().Code;
            label1.Text = loginCode;

            if (String.IsNullOrEmpty(loginCode))
                throw new Exception("获取二维码code失败");

            WechatHttpClient<CodeGenerateResponse, CodeGenerateRequest> CodeWechatHttpClient = new WechatHttpClient<CodeGenerateResponse, CodeGenerateRequest>(new CodeGenerateRequest(loginCode));
            Stream ImageStream = new MemoryStream(CodeWechatHttpClient.DoImageGet());
            Image _image = Image.FromStream(ImageStream);
            pictureBox1.Image = _image;
            ImageStream.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    WechatHttpClient<LoginLoopResponse, LoginLoopRequest> wechatHttpClient = new WechatHttpClient<LoginLoopResponse, LoginLoopRequest>(new LoginLoopRequest(loginCode));
                    LoginLoopResponse loginLoopResponse = wechatHttpClient.DoGet();
                    //登陆跳转授权地址
                    if (loginLoopResponse != null && !string.IsNullOrWhiteSpace(loginLoopResponse.RedirectUri))
                    {
                        authUrl = loginLoopResponse.RedirectUri;
                    }
                    if (!string.IsNullOrEmpty(authUrl))
                        break;

                    System.Threading.Thread.Sleep(1000);
                }
            }
            catch (Exception xe)
            {
                MessageBox.Show("先扫二维码");
            }
            
            WechatHttpClient<WechatInitResponse, WechatInitRequest> wechatHttp = new WechatHttpClient<WechatInitResponse, WechatInitRequest>(new WechatInitRequest(authUrl));

            WechatInitResponse response = wechatHttp.DoGet();
            skey = response.skey;
            label6.Text = skey;
            wxsid = response.wxsid;
            label7.Text = wxsid;
            wxuin = response.wxuin;
            label8.Text = wxuin;
            pass_ticket = response.pass_ticket;
            label9.Text = pass_ticket;

            BaseRequest baseRequest = new BaseRequest();
            baseRequest.Sid = wxsid;
            baseRequest.Uin = wxuin;
            baseRequest.Skey = skey;


            WechatHttpClient<InitResponse, InitPostModel> initWechatHttp = new WechatHttpClient<InitResponse, InitPostModel>(new InitPostModel(pass_ticket, baseRequest));
            InitResponse resp = initWechatHttp.DoPost();
            user_name = resp.User.UserName;

            List<ListSource> source = new List<ListSource>();
            foreach (var item in resp.ContactList)
            {
                source.Add(new ListSource(item.UserName, item.NickName));
            }
            dataGridView1.DataSource = source;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RefushCode();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        public static Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

        private void Button3_Click(object sender, EventArgs e)
        {
            string toUser = textBox3.Text;
            string toMsg = textBox2.Text;
            MsgData data = new MsgData();
            BaseRequest baseRequest = new BaseRequest();
            baseRequest.Sid = wxsid;
            baseRequest.Uin = wxuin;
            baseRequest.Skey = skey;
            data.BaseRequest = baseRequest;

            string at = textBox5.Text;

            Msg _msg = new Msg();
            _msg.Type = 1;
            _msg.Content = (string.IsNullOrEmpty(at)?"":at + " ") + toMsg;
            _msg.FromUserName = user_name;
            _msg.ToUserName = toUser;
            data.Msg = _msg;



            int times = int.Parse(textBox4.Text);

            Task task = Task.Run(()=> 
            {
                int i = 0;
                while (i < times)
                {
                    i++;

                    if (checkBox1.Checked)
                    {
                        int _d = DateTime.Now.Millisecond;
                        Random r = new Random(_d);
                        data.Msg.Content = (string.IsNullOrEmpty(at) ? "" : at + " ") + keyValuePairs[r.Next(1, keyValuePairs.Count)];
                    }

                    if (checkBox2.Checked)
                    {
                        i = 0;
                    }
                    WechatHttpClient<MsgResponse, MsgRequest> wechatHttpClient = new WechatHttpClient<MsgResponse, MsgRequest>(new MsgRequest(pass_ticket, data));
                    MsgResponse response = wechatHttpClient.DoPost();

                    BeginInvoke(new update_textbox(update_text), JsonConvert.SerializeObject(response));
                    BeginInvoke(new update_textbox(lable_text), i.ToString());
                    Thread.Sleep(500);
                }
            });         
        }

        public delegate void update_textbox(string str1);

        private void lable_text(string str)
        {
            label13.Text = str;
        }
        private void update_text(string str)
        {
            textBox1.Text = str;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = this.dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
        }
    }
}
