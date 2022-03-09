<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 193px; position: absolute; top: 187px"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 194px; top: 107px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 194px; top: 63px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 192px; top: 253px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastname" runat="server" style="z-index: 1; left: 194px; top: 145px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 63px; top: 64px; position: absolute; width: 134px" Text="Staff No"></asp:Label>
        <asp:Label ID="lblFirstname" runat="server" style="z-index: 1; left: 63px; top: 108px; position: absolute; width: 135px" Text="First Name"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 64px; top: 258px; position: absolute" Text="Date Added"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 62px; top: 188px; position: absolute" Text="Salary"></asp:Label>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 63px; top: 223px; position: absolute" Text="Gender"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 63px; top: 147px; position: absolute; width: 115px" Text="Last Name"></asp:Label>
        <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 67px; top: 317px; position: absolute" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 66px; top: 362px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 68px; top: 408px; position: absolute; width: 64px; right: 1173px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 156px; top: 408px; position: absolute; width: 64px" Text="Cancel" />
        <asp:DropDownList ID="ddlGender" runat="server" style="z-index: 1; left: 194px; top: 220px; position: absolute">
        </asp:DropDownList>
    </form>
</body>
</html>
