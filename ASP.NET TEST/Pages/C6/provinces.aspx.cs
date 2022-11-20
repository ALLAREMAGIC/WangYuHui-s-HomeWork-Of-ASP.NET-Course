using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ASP.NET_TEST.Pages.C6
{
    public partial class provinces : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var ShengSet = new HashSet<string>();
                var lines = File.ReadAllLines(Server.MapPath("../../MyResources/TextFile.txt"), System.Text.Encoding.Default);
                foreach (var line in lines)
                {
                    var neirong = line.Split('\t');
                    if (ShengSet.Contains(neirong[1]) || neirong[1] == "")
                        continue;
                    ShengSet.Add(neirong[1]);
                    var linkLabel = new HyperLink();
                    var tableRow = new TableRow();
                    var tableCell = new TableCell();
                    linkLabel.Text = neirong[1];
                    linkLabel.NavigateUrl = "~/Pages/C6/cities.aspx?ShengName=" + neirong[1];
                    tableCell.Controls.Add(linkLabel);
                    tableRow.Cells.Add(tableCell);
                    TableSheng.Rows.Add(tableRow);
                }
            }
        }
    }
}