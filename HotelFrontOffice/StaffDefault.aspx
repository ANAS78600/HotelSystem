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
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 113px; top: 367px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:ListBox ID="lstStaffFirstName" runat="server" style="z-index: 1; left: 8px; top: 62px; position: absolute; height: 192px; width: 227px"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 83px; top: 404px; position: absolute; right: 1001px" Text="Edit" Width="55px" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 149px; top: 405px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 13px; top: 404px; position: absolute; width: 55px; right: 1071px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:TextBox ID="txtStaffFirstName" runat="server" style="z-index: 1; left: 11px; top: 319px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <p>
            <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 12px; top: 292px; position: absolute" Text="Please Enter First Name"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnHome" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 287px; top: 144px; position: absolute" Text="Home" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 11px; top: 368px; position: absolute" Text="Apply" Width="94px" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
