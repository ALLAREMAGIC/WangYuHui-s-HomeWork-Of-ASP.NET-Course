using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_TEST.Pages.C5
{
    public partial class CustomServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CvInput_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int value = int.Parse(args.Value);  //获取被验证控件中输入的值
            if ((value % 2) == 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMsg.Text = "验证通过！";
            }
        }
    }
}