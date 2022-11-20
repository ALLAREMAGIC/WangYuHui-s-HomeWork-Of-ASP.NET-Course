using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ASP.NET_TEST
{
    public class Global : HttpApplication
    {
        private void Application_Start(object sender , EventArgs e)
        {
            // 在应用程序启动时运行的代码
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["VisitNumber"] = 0;         //初始化计数器
            Application["IsToRefresh"] = false;
        }

        private void Application_PostRequestHandlerExecute(object sender , EventArgs e)
        {
        }

        private void Session_Start(object sender , EventArgs e)
        {
            // 用于实例6-9
            if(Application["VisitNumber"] != null)
            {
                Application.Lock();
                Application["VisitNumber"] = (int)Application["VisitNumber"] + 1;
                Application.UnLock();
            }
        }

        private void Session_End(object sender , EventArgs e)
        {
            // 在会话结束时运行的代码。
            // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
            // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer
            // 或 SQLServer，则不引发该事件。

            //用于实例6-9
            if(Application["VisitNumber"] != null)
            {
                Application.Lock();
                Application["VisitNumber"] = (int)Application["VisitNumber"] - 1;
                Application.UnLock();
            }
        }
    }
}