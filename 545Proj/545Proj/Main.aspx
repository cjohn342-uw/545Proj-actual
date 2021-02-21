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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
