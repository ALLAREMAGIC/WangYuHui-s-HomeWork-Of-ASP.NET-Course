<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5-3 RangeValidator控件.aspx.cs" Inherits="ASP.NET_TEST.Pages.C5._5_3_RangeValidator控件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      成绩：<asp:TextBox ID="txtGrade" runat="server"></asp:TextBox>
      <asp:RangeValidator ID="rvGrade" runat="server" ControlToValidate="txtGrade" MaximumValue="100" MinimumValue="0" Type="Double">应输入0～100之间的数！</asp:RangeValidator><br />
      日期：<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
      <asp:RangeValidator ID="rvDate" runat="server" ControlToValidate="txtDate" MaximumValue="2025-1-1" MinimumValue="2022-1-1" Type="Date">日期错误!</asp:RangeValidator>
    </div>
  </form>
</body>
</html>
