<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteBooking.aspx.cs" Inherits="DeleteBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this booking?"></asp:Label>
        </p>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
