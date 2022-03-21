<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnSupplier.aspx.cs" Inherits="AnSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplierNo" runat="server" style="z-index: 1; left: 65px; top: 119px; position: absolute" Text="SupplierNo"></asp:Label>
        <asp:Label ID="lblSupplierFirstName" runat="server" style="z-index: 1; left: 54px; top: 170px; position: absolute; height: 28px; right: 523px;" Text="Supplier First Name"></asp:Label>
        <asp:Label ID="lblSupplierLastName" runat="server" style="z-index: 1; left: 57px; top: 217px; position: absolute" Text="Supplier Last Name"></asp:Label>
        <asp:Label ID="lblSupplierTel" runat="server" style="z-index: 1; left: 63px; top: 256px; position: absolute" Text="Supplier Tel"></asp:Label>
        <asp:Label ID="lblSupplierAddress" runat="server" style="z-index: 1; left: 56px; top: 300px; position: absolute" Text="Supplier Address"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 65px; top: 343px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtSupplierNo" runat="server" style="z-index: 1; left: 268px; top: 122px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplierFirstName" runat="server" style="z-index: 1; left: 266px; top: 167px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplierLastName" runat="server" style="z-index: 1; left: 268px; top: 214px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplierTel" runat="server" style="z-index: 1; left: 269px; top: 258px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 270px; top: 299px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 268px; position: absolute; top: 341px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 56px; top: 403px; position: absolute" Text="Active" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 55px; top: 451px; position: absolute" Text="[IblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 40px; top: 500px; position: absolute; height: 36px; width: 49px" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 121px; top: 502px; position: absolute; height: 33px; width: 88px" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 466px; top: 109px; position: absolute" Text="Find" OnClick="btnFind_Click" />
    </form>
</body>
</html>
