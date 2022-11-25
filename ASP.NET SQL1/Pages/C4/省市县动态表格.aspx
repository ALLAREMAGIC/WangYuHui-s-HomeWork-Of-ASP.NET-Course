<%@ Page Language="C#" AutoEventWireup="true" CodeFile="省市县动态表格.aspx.cs" Inherits="Pages_C4_省市县动态表格1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ShowBtn" runat="server" OnClick="ShowBtn_Click" Text="点击显示/隐藏表格头" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="点击加载信息" />
            <asp:Table ID="SSX_Table" runat="server" GridLines="Both">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">序号</asp:TableCell>
                    <asp:TableCell runat="server">邮编</asp:TableCell>
                    <asp:TableCell runat="server">省</asp:TableCell>
                    <asp:TableCell runat="server">市</asp:TableCell>
                    <asp:TableCell runat="server">县</asp:TableCell>
                    <asp:TableCell runat="server">全称</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
