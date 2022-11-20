<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5-6 CustomServer.aspx.cs" Inherits="ASP.NET_TEST.Pages.C5.CustomServer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      数值：<asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
      <asp:CustomValidator ID="cvInput" runat="server" ControlToValidate="txtInput" OnServerValidate="CvInput_ServerValidate">不是一个偶数！</asp:CustomValidator>
      <br />
      <asp:Button ID="btnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="确定" />
      <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </div>
  </form>
</body>
</html>
