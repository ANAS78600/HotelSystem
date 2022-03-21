<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnCancel" runat="server" OnClick="Button2_Click" style="z-index: 1; position: absolute; top: 499px" Text="Cancel" />
        </div>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 135px; position: absolute; top: 278px"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 139px; top: 198px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtGuestNo" runat="server" style="z-index: 1; left: 140px; top: 327px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 463px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkOK" runat="server" style="z-index: 1; left: 14px; top: 428px; position: absolute" Text="Active" />
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 11px; top: 283px; position: absolute" Text="Name"></asp:Label>
            <asp:Label ID="lblGuestNo" runat="server" style="z-index: 1; left: 12px; top: 326px; position: absolute" Text="Number of Guests"></asp:Label>
            <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 10px; top: 203px; position: absolute" Text="Date"></asp:Label>
            <asp:Label ID="lblCustID" runat="server" style="z-index: 1; left: 5px; top: 238px; position: absolute" Text="CustomerID"></asp:Label>
            <asp:TextBox ID="txtCustID" runat="server" style="z-index: 1; left: 138px; top: 239px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <p>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 107px; top: 499px; position: absolute" Text="Ok" />
            <asp:Label ID="lblBookingID" runat="server" style="z-index: 1; left: 18px; top: 371px; position: absolute" Text="Booking ID"></asp:Label>
            <asp:TextBox ID="txtBookingID" runat="server" style="z-index: 1; left: 144px; top: 369px; position: absolute" OnTextChanged="txtBookingId_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
