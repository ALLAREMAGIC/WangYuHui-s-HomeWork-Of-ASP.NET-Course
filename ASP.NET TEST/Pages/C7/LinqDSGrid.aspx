<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqDSGrid.aspx.cs" Inherits="ASP.NET_TEST.Pages.C7.LinqDSGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinqDataSource ID="ldsCategory" runat="server"></asp:LinqDataSource>
            <asp:GridView ID="gvCategory" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
