using ASP.NET_TEST.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_TEST.Pages.C4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SSX_Table.Visible = false;
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Default.aspx");
        }

        protected void ShowBtn_Click(object sender, EventArgs e)
        {
            SSX_Table.Visible = !SSX_Table.Visible;
            //SSX_Table.Visible = false;
        }

        private void ShowAllInfo()
        {
            var lines = System.IO.File.ReadAllLines(Server.MapPath("../../MyResources/TextFile.txt"));
            int num = 1;
            foreach (var line in lines)
            {
                var neirong = line.Split('\t');
                TableRow tableRow = new TableRow();
                TableCell cellNum = new TableCell();
                TableCell cellYoubian = new TableCell();
                TableCell cellSheng = new TableCell();
                TableCell cellShi = new TableCell();
                TableCell cellXian = new TableCell();
                TableCell cellTog = new TableCell();
                cellNum.Text = num.ToString();
                num++;
                cellYoubian.Text = neirong[0];
                cellSheng.Text = neirong[1];
                cellShi.Text = neirong[2];
                cellXian.Text = neirong[3];
                cellTog.Text = neirong[4];
                tableRow.Cells.Add(cellNum);
                tableRow.Cells.Add(cellYoubian);
                tableRow.Cells.Add(cellSheng);
                tableRow.Cells.Add(cellShi);
                tableRow.Cells.Add(cellXian);
                tableRow.Cells.Add(cellTog);
                SSX_Table.Rows.Add(tableRow);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ShowAllInfo();
        }
    }
}