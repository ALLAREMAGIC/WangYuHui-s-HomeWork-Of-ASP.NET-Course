using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_TEST.ChatRoom
{
    public partial class ChatRoom : System.Web.UI.Page
    {
        private Dictionary<string , string> nameDic = new Dictionary<string , string>();

        protected void Page_Load(object sender , EventArgs e)
        {
            if(Application["nameDic"] != null)
            {
                nameDic = (Dictionary<string , string>)Application["nameDic"];
                if(nameDic.ContainsKey(Request.UserHostAddress))
                {
                    lblMsg.Text = nameDic[Request.UserHostAddress] + "，欢迎您！";
                }
                else
                {
                    Response.Redirect("~/ChatRoom/Register.aspx");
                }
            }
            else
            {
                Response.Redirect("~/ChatRoom/Register.aspx");
            }
        }
    }
}