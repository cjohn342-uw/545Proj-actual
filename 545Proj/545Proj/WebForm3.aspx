<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="_545Proj.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Search Pets<br />
            <asp:TextBox ID="selectPetType" runat="server" OnTextChanged="selectPetType_TextChanged">Name, breed, etc</asp:TextBox>
            <br />
            <asp:Button ID="SelectPet" runat="server" OnClick="SelectPet_Click" Text="Find your new friend!" />
            <br />
            <asp:Label ID="changeMe" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Search Items<br />
            <asp:TextBox ID="selectProdField" runat="server" OnTextChanged="selectProdName_TextChanged">Item Info</asp:TextBox>
            <br />
            <asp:Button ID="Search" runat="server" OnClick="Search_Click" Text="Search" />
            <br />
            <asp:Label ID="changeMe2" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Purchase Item<br />
            <asp:TextBox ID="sku" runat="server">SKU</asp:TextBox>
            <asp:TextBox ID="quantity" runat="server">Quantity</asp:TextBox>
            <br />
            <asp:Button ID="Purchase" runat="server" OnClick="Purchase_Click" Text="Purchase" />
            <br />
            <asp:Label ID="PurchaseItem" runat="server"></asp:Label>
            <asp:Label ID="ErrorText" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
