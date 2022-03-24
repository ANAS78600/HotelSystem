<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

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
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 95px; top: 133px; position: absolute" Text="Are you sure you want to delete this Customer?"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 132px; top: 189px; position: absolute; height: 26px; width: 47px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 239px; top: 187px; position: absolute; height: 27px; width: 54px" Text="No" />
        </p>
    </form>
</body>
</html>
