<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASP.NET_TEST.ChatRoom.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>聊天室登录</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请登录：<asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="(请注意确认名称后和IP绑定！)"></asp:Label>
            <br />
            <br/>
            名称：<asp:TextBox ID="TextBoxLogName" runat="server" Height="16px" Width="345px"></asp:TextBox>
            <br />
            <br />
            <asp:CustomValidator ID="NameValidator" runat="server" ControlToValidate="TextBoxLogName" ErrorMessage="输入非法！请重新输入！" OnServerValidate="NameValidator_ServerValidate"></asp:CustomValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxLogName">不能为空！</asp:RequiredFieldValidator>
            <asp:CustomValidator ID="HavenName" runat="server" ErrorMessage="已有人使用名称！" ControlToValidate="TextBoxLogName" OnServerValidate="HavenName_ServerValidate"></asp:CustomValidator>
            <br />
            <asp:Button ID="ButtonLog" runat="server" Text="确定" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
