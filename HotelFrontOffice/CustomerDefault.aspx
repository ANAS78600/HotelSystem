<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

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
            <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 69px; top: 301px; position: absolute" Text="Please Enter First Name"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 44px; top: 399px; position: absolute; right: 1165px" Text="Apply" Width="94px" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 186px; top: 391px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 46px; top: 461px; position: absolute; width: 55px" Text="Add" OnClick="btnAdd_Click"  />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 137px; top: 465px; position: absolute; right: 1111px; height: 26px;" Text="Edit" Width="55px" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 232px; top: 460px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 71px; top: 274px; position: absolute" Text="[IblError]"></asp:Label>
        <asp:ListBox ID="lstFirstName" runat="server" style="z-index: 1; left: 53px; top: 29px; position: absolute; height: 224px; width: 251px" OnSelectedIndexChanged="lstFirstName_SelectedIndexChanged"></asp:ListBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 64px; top: 328px; position: absolute; width: 174px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
