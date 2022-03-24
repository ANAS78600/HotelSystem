<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 129px; top: 369px; position: absolute; height: 33px; width: 88px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 55px; top: 365px; position: absolute; height: 36px; width: 49px" Text="OK" OnClick="btnOK_Click" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 61px; top: 329px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 65px; top: 90px; position: absolute" Text="CustomerID"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 63px; top: 121px; position: absolute; width: 78px; right: 1369px;" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 62px; top: 147px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblTel" runat="server" style="z-index: 1; left: 64px; top: 177px; position: absolute" Text="Tel"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 63px; top: 204px; position: absolute" Text=" Address"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 65px; top: 239px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 205px; top: 88px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 203px; top: 116px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 201px; top: 143px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTel" runat="server" style="z-index: 1; left: 203px; top: 170px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 197px; top: 201px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 194px; top: 237px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 400px; top: 100px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 63px; top: 286px; position: absolute" Text="Active" />
        </p>
    </form>
</body>
</html>
