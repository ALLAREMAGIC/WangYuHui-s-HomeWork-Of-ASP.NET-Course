<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatRoom.aspx.cs" Inherits="ASP.NET_TEST.ChatRoom.ChatRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>聊天室验证</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <iframe src="ShowChats.aspx" title="显示框" style="width: 890px; height: 308px ;border:none;" id="ShowChatsFrame"></iframe>
        <br />
      <asp:Label ID="lblMsg"  runat="server"></asp:Label>
        <br />
        <iframe src="UserChat.aspx" title="输入框" style="border-style: none; border-color: inherit; border-width: medium; width: 890px; height: 226px;" id="InputChatsFrame"></iframe>
    </div>
  </form>
</body>
</html>
