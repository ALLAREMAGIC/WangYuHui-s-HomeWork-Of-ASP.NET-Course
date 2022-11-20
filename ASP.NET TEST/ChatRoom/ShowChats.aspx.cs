using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_TEST.ChatRoom
{
    public partial class ShowChats : System.Web.UI.Page
    {
        private List<string> messageList = new List<string>();

        protected void Page_Load(object sender , EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            if(Application["messageList"] != null)
            {
                messageList = (List<string>)Application["messageList"];
                foreach(var neirong in messageList)
                {
                    Response.Write(neirong);
                }
            }
        }
    }
}