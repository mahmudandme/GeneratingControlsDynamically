<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GeneratingDynamicServerControls.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:DropDownList ID="DropDownList1" runat="server" >
            <asp:ListItem Text="10" Value="1" ></asp:ListItem>
             <asp:ListItem Text="20" Value="2" ></asp:ListItem>
             <asp:ListItem Text="30" Value="3" ></asp:ListItem>
             <asp:ListItem Text="40" Value="4" ></asp:ListItem>
        </asp:DropDownList>
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    </div>
    </form>
</body>
</html>
