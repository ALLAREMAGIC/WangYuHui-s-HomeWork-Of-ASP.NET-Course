﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="省市县三级联动.aspx.cs" Inherits="ASP.NET_TEST.Pages.C4.省市县三级联动" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>省市县三级联动</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ShengList" runat="server" OnSelectedIndexChanged="ShengList_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
&nbsp;省 
            <asp:DropDownList ID="ShiList" runat="server" OnSelectedIndexChanged="ShiList_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
&nbsp;市 
            <asp:DropDownList ID="XianList" runat="server" AutoPostBack="True">
            </asp:DropDownList>
&nbsp;县</div>
        <div>
            <asp:Button ID="BackButton1" runat="server" OnClick="BackButton_Click" Text="返回首页" /></div>
    </form>
</body>
</html>
