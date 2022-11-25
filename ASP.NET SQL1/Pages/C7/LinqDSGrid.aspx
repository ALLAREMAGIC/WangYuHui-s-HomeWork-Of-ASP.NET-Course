<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqDSGrid.aspx.cs" Inherits="Pages_C7_LinqDSGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinqDataSource ID="ldsCategory" runat="server" ContextTypeName="MyPetShopEntities" EntityTypeName="" TableName="Category"></asp:LinqDataSource>
            <asp:GridView ID="gvCategory" runat="server" AutoGenerateColumns="False" DataSourceID="ldsCategory">
                <Columns>
                    <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Descn" HeaderText="Descn" SortExpression="Descn" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
