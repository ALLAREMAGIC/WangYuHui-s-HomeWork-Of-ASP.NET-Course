using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ASP.NET_TEST.Pages.C6
{
    public partial class cities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var shengName = Request.QueryString["ShengName"];
            LabelShengName.Text = shengName;
            var shiSet = new HashSet<string>();
            var lines = File.ReadAllLines(Server.MapPath("../../MyResources/TextFile.txt"), System.Text.Encoding.Default);
            foreach (var line in lines)
            {
                var neirong = line.Split('\t');
                if (shiSet.Contains(neirong[2]) || neirong[1] != shengName || neirong[2] == "" || neirong[2] == "市辖区")
                    continue;

                var tableRow = new TableRow();
                var tableCell = new TableCell();
                if (neirong[2] == "省直辖行政单位")
                {
                    shiSet.Add(neirong[3]);
                    tableCell.Text = neirong[3];
                }
                else
                {
                    shiSet.Add(neirong[2]);
                    tableCell.Text = neirong[2];
                }
                tableRow.Cells.Add(tableCell);
                TableCities.Rows.Add(tableRow);
            }
        }
    }
}