using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Pages_C4_省市县三级联动手动版 : System.Web.UI.Page
{
    private string[] lines;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindSheng();
            BindShi();
            BindXian();
        }
    }

    private void BindSheng()
    {
        ShengList.Items.Clear();
        lines = File.ReadAllLines(Server.MapPath("../../MyResources/TextFile.txt"), System.Text.Encoding.Default);
        foreach (var line in lines)
        {
            var neirong = line.Split('\t');
            if (ShengList.Items.FindByText(neirong[1]) != null || neirong[1] == "")
                continue;
            ShengList.Items.Add(neirong[1]);
        }
    }

    private void BindShi()
    {
        ShiList.Items.Clear();
        lines = File.ReadAllLines(Server.MapPath("../../MyResources/TextFile.txt"), System.Text.Encoding.Default);
        foreach (var line in lines)
        {
            if (line.Contains(ShengList.SelectedItem.Text))
            {
                var neirong = line.Split('\t');
                if (ShiList.Items.FindByText(neirong[2]) != null || neirong[2] == "" /*|| neirong[2] == "市辖区"*/)
                    continue;
                ShiList.Items.Add(neirong[2]);
            }
        }
    }

    private void BindXian()
    {
        XianList.Items.Clear();
        lines = File.ReadAllLines(Server.MapPath("../../MyResources/TextFile.txt"), System.Text.Encoding.Default);
        foreach (var line in lines)
        {
            if (line.Contains(ShiList.SelectedItem.Text) && line.Contains(ShengList.SelectedItem.Text))
            {
                var neirong = line.Split('\t');
                if (XianList.Items.FindByText(neirong[3]) != null || neirong[3] == "" || neirong[3] == "市辖区")
                    continue;
                XianList.Items.Add(neirong[3]);
            }
        }
    }

    protected void ShengList_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindShi();
        BindXian();
    }

    protected void ShiList_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindXian();
    }

}