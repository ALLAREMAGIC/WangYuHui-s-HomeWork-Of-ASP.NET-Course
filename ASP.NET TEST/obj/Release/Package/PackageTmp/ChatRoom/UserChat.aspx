<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="UserChat.aspx.cs" Inherits="ASP.NET_TEST.ChatRoom.UserChat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>聊天室本体</title>
    <style type="text/css">
        #TextArea1 {
            height: 105px;
            width: 187px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            当前用户在线人数：<asp:Label ID="lblMsg" runat="server"></asp:Label>
            <br />
            <br />
                输入：<asp:Label ID="Label1" runat="server" BackColor="Red" ForeColor="White" Text="(输入字符数目做了限制，请勿超过40)"></asp:Label>
                <br /> 
                <asp:TextBox ID="TextBoxMassage" runat="server" Height="65px" Width="646px" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:CustomValidator ID="CustomValidator" runat="server" ControlToValidate="TextBoxMassage" ErrorMessage="字符非法！请删除相关字符！" OnServerValidate="CustomValidator_ServerValidate"></asp:CustomValidator>
                <br />
                <asp:Button ID="ButtonSendMassage" runat="server" Height="60px" OnClick="ButtonSendMassage_Click" style="margin-top: 0px" Text="发送" Width="114px" />
                <asp:Button ID="ButtonClear" runat="server" Height="60px" OnClick="ButtonClear_Click" style="margin-top: 0px" Text="清空" Width="114px" Visible="False" />
        </div>
    </form>
</body>
</html>
