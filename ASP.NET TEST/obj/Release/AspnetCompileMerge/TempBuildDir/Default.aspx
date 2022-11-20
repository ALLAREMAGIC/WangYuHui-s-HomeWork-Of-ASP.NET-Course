<%@ Page Title="首页" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_TEST._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>首页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Button ID="ToStnButton" runat="server" OnClick="ToStnButton_Click" Text="点击跳转到实际网页" Height="51px" />
            </h1>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="40pt" BackColor="#009999" BorderColor="#6699FF" BorderStyle="Outset" ForeColor="White" NavigateUrl="~/ChatRoom/ChatRoom.aspx">聊天室</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:Table ID="TableCatalog" runat="server" Caption="目录（因为懒,所以动态加载目录）哈哈，没有直接进聊天室的！" GridLines="Both" Width="487px">
                <asp:TableRow>
                    <asp:TableHeaderCell>序号</asp:TableHeaderCell>
                    <asp:TableHeaderCell>章节</asp:TableHeaderCell>
                    <asp:TableHeaderCell>案例链接</asp:TableHeaderCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
