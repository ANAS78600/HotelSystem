<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="StaffDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 80px; top: 407px; position: absolute; right: 1036px" Text="Apply" Width="94px" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 199px; top: 406px; position: absolute" Text="Display All" />
        <asp:ListBox ID="lstStaffFirstName" runat="server" style="z-index: 1; left: 79px; top: 93px; position: absolute; height: 192px; width: 227px"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 160px; top: 489px; position: absolute; right: 995px" Text="Edit" Width="55px" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 247px; top: 490px; position: absolute" Text="Delete" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 70px; top: 490px; position: absolute; width: 55px" Text="Add" OnClick="btnAdd_Click" />
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 104px; top: 349px; position: absolute; width: 156px"></asp:TextBox>
        <p>
            <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 105px; top: 317px; position: absolute" Text="Please Enter First Name"></asp:Label>
        </p>
    </form>
</body>
</html>
