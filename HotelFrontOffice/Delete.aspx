<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 168px; top: 133px; position: absolute; width: 47px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 245px; top: 133px; position: absolute; height: 27px; width: 54px" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 124px; top: 95px; position: absolute" Text="Are you sure you want to delete this Supplier?"></asp:Label>
    </form>
</body>
</html>
