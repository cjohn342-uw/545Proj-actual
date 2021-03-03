<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectionName.aspx.cs" Inherits="_545Proj.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:HyperLink ID="ownerLink" runat="server" NavigateUrl="https://545project.azurewebsites.net/Main.aspx">Owners Click Here</asp:HyperLink> <! -- for owners to click, takes you to adding/editing page -->
        <br />
        <br />
        <asp:HyperLink ID="customerLink" runat="server" ClientIDMode="Static" NavigateUrl="https://545project.azurewebsites.net/WebForm3.aspx">Customers Click Here</asp:HyperLink> <! -- for clients to click, takes you to purchasing/searching page -->
    </form>
</body>
</html>
