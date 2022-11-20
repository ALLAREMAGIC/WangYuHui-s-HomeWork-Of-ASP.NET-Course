using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ASP.NET_TEST.ChatRoom
{
    public partial class UserChat : System.Web.UI.Page
    {
        private List<string> messageList = new List<string>();
        private Dictionary<string , string> nameDic = new Dictionary<string , string>();

        protected void Page_Load(object sender , EventArgs e)
        {
            if(Application["nameDic"] == null)
            {
                Application["nameDic"] = nameDic;
            }
            else
            {
                nameDic = (Dictionary<string , string>)Application["nameDic"];
            }

            if(nameDic[Request.UserHostAddress] == null)
            {
                Response.Redirect("~/ChatRoom/Register.aspx");
            }
            if(nameDic[Request.UserHostAddress].ToString() == "magicwang")
            {
                ButtonClear.Visible = true;
            }
            lblMsg.Text = Application["VisitNumber"].ToString();  //显示网站在线人数
        }

        protected void ButtonSendMassage_Click(object sender , EventArgs e)
        {
            if(TextBoxMassage.Text == "")
                return;
            if(!CustomValidator.IsValid)
                return;

            string user = nameDic[Request.UserHostAddress].ToString();
            string message = TextBoxMassage.Text;
            string timeNow = DateTime.Now.ToString();
            string userip = Request.UserHostAddress;
            string sendMessage = timeNow + " 的时候 <br>" + user + " 在IP为 " + userip + " 的地方说<br> " + message + "<br>";
            if(Application["messageList"] == null)
            {
                messageList.Add(sendMessage);
                Application["messageList"] = messageList;
            }
            else
            {
                messageList = (List<string>)Application["messageList"];
                messageList.Add(sendMessage);
                Application["messageList"] = messageList;
            }
            TextBoxMassage.Text = "";
        }

        protected void ButtonClear_Click(object sender , EventArgs e)
        {
            Application.Remove("MessageList");
        }

        protected void CustomValidator_ServerValidate(object source , ServerValidateEventArgs args)
        {
            var content = args.Value;
            if(content.Contains("晖") || content.Contains("宇辉") || content.Contains("望") || content.Contains("共产") || content.Contains("党中央") || content.Contains("近平"))
            {
                args.IsValid = false;
                CustomValidator.Text = "字符非法！请删除相关字符！";
            }
            else if(content.Length >= 40)
            {
                args.IsValid = false;
                CustomValidator.Text = "目前有" + content.Length + "个字符" + "上限40个字符，请适量删除字符！";
            }
        }
    }
}