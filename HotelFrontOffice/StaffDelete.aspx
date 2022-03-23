<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDelete.aspx.cs" Inherits="StaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 147px; top: 107px; position: absolute" Text="No" Width="56px" OnClick="btnNo_Click" />
                <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 77px; top: 107px; position: absolute" Text="Yes" Width="56px" OnClick="btnYes_Click" />
                <asp:Label ID="lblDeleteStaff" runat="server" style="z-index: 1; left: 52px; top: 58px; position: absolute; width: 252px; margin-bottom: 0px" Text="Are you sure you want to delete this staff member?"></asp:Label>

        </div>
    </form>
</body>
</html>
