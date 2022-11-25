<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cities.aspx.cs" Inherits="Pages_C6_Cities1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            省份：<asp:Label ID="LabelShengName" runat="server"></asp:Label>
            <asp:Table ID="TableCities" runat="server" Width="198px" GridLines="Both">
                <asp:TableRow>
                    <asp:TableCell>城市</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
