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
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 130px; top: 444px; position: absolute; height: 33px; width: 88px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 49px; top: 434px; position: absolute; height: 36px; width: 49px" Text="OK" OnClick="btnOK_Click" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 63px; top: 388px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 65px; top: 90px; position: absolute" Text="CustomerID"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 59px; top: 136px; position: absolute; width: 111px; right: 1133px; height: 35px;" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 59px; top: 183px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 57px; top: 217px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblTel" runat="server" style="z-index: 1; left: 65px; top: 258px; position: absolute" Text="Tel"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 58px; top: 293px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 205px; top: 88px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 200px; top: 134px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 202px; top: 212px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTel" runat="server" style="z-index: 1; left: 221px; top: 250px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 218px; top: 291px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 400px; top: 100px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 61px; top: 337px; position: absolute" Text="Active" />
        </p>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 199px; top: 173px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
