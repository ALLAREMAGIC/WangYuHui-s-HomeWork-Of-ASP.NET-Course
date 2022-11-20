<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4-1 IsPostBack.aspx.cs" Inherits="ASP.NET_TEST.Pages.C4._4_1_IsPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="BtnSubmit_Click"/>
            
        </div>
            <asp:Button ID="BackButton" runat="server" OnClick="BackButton_Click" Text="返回首页" />
    </form>
</body>
</html>
