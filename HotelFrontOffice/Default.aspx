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
        <asp:ListBox ID="lstSupplierFirstName" runat="server" style="z-index: 1; left: 53px; top: 29px; position: absolute; height: 224px; width: 251px"></asp:ListBox>
        <asp:Label runat="server" style="z-index: 1; left: 67px; top: 295px; position: absolute; width: 211px" Text="Please Enter First Name"></asp:Label>
        <asp:TextBox ID="txtSupplierFirstName" runat="server" style="z-index: 1; left: 64px; top: 325px; position: absolute; width: 174px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 63px; top: 373px; position: absolute; height: 31px; width: 86px" Text="Apply" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 219px; top: 452px; position: absolute" Text="DELETE" OnClick="btnDelete_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 43px; top: 452px; position: absolute; height: 26px;" Text="Add" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 200px; top: 373px; position: absolute" Text="Display All" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 122px; top: 451px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 64px; top: 256px; position: absolute" Text="[IblError]"></asp:Label>
    </form>
</body>
</html>
