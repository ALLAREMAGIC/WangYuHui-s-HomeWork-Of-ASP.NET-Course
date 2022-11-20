<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5-1 RequiredFieldVaildator控件.aspx.cs" Inherits="ASP.NET_TEST.Pages.C5._5_1_RequiredFieldVaildator控件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        用户名：<asp:TextBox ID="txtName" runat="server" OnTextChanged="TextBox1_TextChanged">您的姓名</asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName1" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="rfvNmae2" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" InitialValue="您的姓名">不能和初始值相同</asp:RequiredFieldValidator>
        </div>
    </form>
</body>
</html>
