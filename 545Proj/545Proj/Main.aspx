<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="_545Proj.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        New Pet<p>
            <asp:TextBox ID="PetNameInsert" runat="server" OnTextChanged="TextBox1_TextChanged">Pet Name</asp:TextBox>
            <asp:TextBox ID="PetTypeInsert" runat="server">(Dog, Cat, Etc)</asp:TextBox>
            <asp:TextBox ID="BreedInsert" runat="server">Breed</asp:TextBox>
            <asp:TextBox ID="BirthdayInsert" runat="server">Birthday</asp:TextBox>
            <asp:TextBox ID="petDescriptionInsert" runat="server">Description</asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Pet" />
        <br />
        <br />
        Pet Adopted!<br />
        <asp:TextBox ID="petID" runat="server">Pet ID</asp:TextBox>
        <br />
        <asp:Button ID="adoptButton" runat="server" OnClick="adoptButton_Click" Text="Adopted!" />
        <br />
        <br />
        <p>
            New Product</p>
        <asp:TextBox ID="productName" runat="server">Product Name</asp:TextBox>
        <asp:TextBox ID="prodDescription" runat="server">Product Description</asp:TextBox>
        <asp:TextBox ID="prodPrice" runat="server">Product Price </asp:TextBox>
        <asp:TextBox ID="prodQuantity" runat="server">Product Quantity</asp:TextBox>
        <asp:TextBox ID="prodDept" runat="server">Product Department</asp:TextBox>
        <p>
            <asp:Button ID="prodButton" runat="server" OnClick="prodButton_Click" Text="Add Product" />
        </p>
        <p>
            Update Product</p>
        <p>
            <asp:TextBox ID="sku" runat="server" OnTextChanged="TextBox1_TextChanged">Product SKU</asp:TextBox>
            <asp:TextBox ID="updateProdName" runat="server">Product Name</asp:TextBox>
            <asp:TextBox ID="updateProdDesc" runat="server">Product Description</asp:TextBox>
            <asp:TextBox ID="updateProdPrice" runat="server">Product Price</asp:TextBox>
            <asp:TextBox ID="updateProdQuantity" runat="server">Product Quantity</asp:TextBox>
            <asp:TextBox ID="updateProdDept" runat="server">Product Department</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="UpdateButton" runat="server" OnClick="UpdateButton_Click" Text="Update Product" />
        </p>
    </form>
</body>
</html>
