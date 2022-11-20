using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_TEST.Pages.C4
{
    public partial class _4_1_IsPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Response.Write("页面第一次加载");
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("执行Click时间处理代码");
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Default.aspx");
        }
    }
}