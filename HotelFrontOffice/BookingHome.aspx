<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingHome.aspx.cs" Inherits="BookingHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstBooking" runat="server" Height="170px" Width="252px" OnSelectedIndexChanged="lstBooking_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblCustID" runat="server" Text="Please enter your Customer ID"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" Text="Apply" Width="123px" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" Width="123px" OnClick="btnDisplayAll_Click" />
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
            <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </p>
    </form>
</body>
</html>
