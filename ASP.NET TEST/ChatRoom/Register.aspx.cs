using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_TEST.ChatRoom
{
    public partial class Register : System.Web.UI.Page
    {
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
        }

        protected void NameValidator_ServerValidate(object source , ServerValidateEventArgs args)
        {
            string name = args.Value;
            if(name == "")
                args.IsValid = false;

            char[] chars = new char[]
            {
                '\n','\t',' ',
            };
            foreach(var c in chars)
            {
                if(name.Contains(c))
                    args.IsValid = false;
            }

            if(name.Contains("晖") || name.Contains("宇辉") || name.Contains("望"))
            {
                args.IsValid = false;
            }
        }

        protected void Button1_Click(object sender , EventArgs e)
        {
            if(NameValidator.IsValid && HavenName.IsValid)
            {
                nameDic.Add(Request.UserHostAddress , TextBoxLogName.Text);
                Application["nameDic"] = nameDic;
                Response.Redirect("~/ChatRoom/ChatRoom.aspx");
            }
        }

        protected void HavenName_ServerValidate(object source , ServerValidateEventArgs args)
        {
            string name = args.Value;
            if(nameDic.ContainsValue(name))
            {
                args.IsValid = false;
            }
        }
    }
}