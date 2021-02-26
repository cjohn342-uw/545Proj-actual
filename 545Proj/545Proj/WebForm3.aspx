<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="_545Proj.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Purchase Item<br />
            <asp:TextBox ID="sku" runat="server">SKU</asp:TextBox>
            <asp:TextBox ID="quantity" runat="server">Quantity</asp:TextBox>
            <br />
            <asp:Button ID="Purchase" runat="server" OnClick="Purchase_Click" Text="Purchase" />
            <br />
            <br />
            Search Pets<br />
        </div>
    </form>
</body>
</html>
