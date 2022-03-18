<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierFirstName" runat="server" style="z-index: 1; left: 53px; top: 59px; position: absolute; height: 200px; width: 251px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 67px; top: 295px; position: absolute; width: 183px" Text="Please Enter First Name"></asp:Label>
        <asp:TextBox ID="txtSupplierFirstName" runat="server" style="z-index: 1; left: 64px; top: 325px; position: absolute; width: 174px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 63px; top: 373px; position: absolute; height: 31px; width: 86px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 164px; top: 372px; position: absolute; height: 30px; width: 90px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 38px; top: 451px; position: absolute; width: 66px; height: 28px" Text="ADD" />
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 123px; top: 452px; position: absolute; height: 28px; width: 70px; bottom: 177px; margin-bottom: 0px" Text="EDIT" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 219px; top: 452px; position: absolute" Text="DELETE" />
    </form>
</body>
</html>
