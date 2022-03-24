<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainHome.aspx.cs" Inherits="MainHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="BtnBookings" runat="server" OnClick="BtnBookings_Click" Text="Bookings Page" />
        </p>
        <p>
            <asp:Button ID="BtnCustomers" runat="server" OnClick="BtnCustomers_Click" Text="Customers Page" />
        </p>
        <p>
            <asp:Button ID="BtnStaff" runat="server" OnClick="BtnStaff_Click" Text="Staff Page" />
        </p>
        <p>
            <asp:Button ID="BtnSuppliers" runat="server" OnClick="BtnSuppliers_Click" Text="Suppliers Page" />
        </p>
    </form>
</body>
</html>
