using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //是否不为服务器打开的按钮
        if (Request.Url.Host.ToString() == "124.223.12.219")
            ToStnButton.Visible = false;

        //动态加载目录表格
        System.IO.DirectoryInfo[] allPageDirs = new System.IO.DirectoryInfo(Server.MapPath("/Pages")).GetDirectories();
        bool isCreateDir = false;
        int num = 1;
        foreach (System.IO.DirectoryInfo dir in allPageDirs)
        {
            System.IO.FileInfo[] allFiles = dir.GetFiles();
            foreach (System.IO.FileInfo file in allFiles)
            {
                if (System.IO.Path.GetExtension(file.FullName) != ".aspx")
                    continue;

                TableRow tableRow = new TableRow();

                TableCell cellNum = new TableCell();
                cellNum.Text = num.ToString();
                tableRow.Cells.Add(cellNum);

                TableCell cellChap = new TableCell();
                if (!isCreateDir)
                {
                    cellChap.Text = dir.Name;
                    isCreateDir = true;
                }
                tableRow.Cells.Add(cellChap);

                TableCell cellPage = new TableCell();
                HyperLink pagelink = new HyperLink();
                pagelink.Text = file.Name;
                pagelink.NavigateUrl = "~/Pages/" + dir.Name + "/" + file.Name;
                cellPage.Controls.Add(pagelink);
                tableRow.Cells.Add(cellPage);

                TableCatalog.Rows.Add(tableRow);
                num++;
            }
            isCreateDir = false;
        }
    }

    protected void ToStnButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://124.223.12.219/", false);
    }
}