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
        <asp:ListBox ID="lstFirstName" runat="server" style="z-index: 1; left: 91px; top: 75px; position: absolute; height: 192px; width: 227px; bottom: 319px;" OnSelectedIndexChanged="lstFirstName_SelectedIndexChanged1"></asp:ListBox>
        <p>
            <asp:Label ID="lblEnterFirstName" runat="server" style="z-index: 1; left: 69px; top: 301px; position: absolute" Text="Please Enter First Name"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 55px; top: 364px; position: absolute; right: 1154px" Text="Apply" Width="94px" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 189px; top: 365px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 46px; top: 439px; position: absolute; width: 55px" Text="Add"  />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 136px; top: 442px; position: absolute; right: 1112px" Text="Edit" Width="55px" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 232px; top: 443px; position: absolute" Text="Delete" />
        </p>
    </form>
</body>
</html>
