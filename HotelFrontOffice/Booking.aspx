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
        <asp:TextBox ID="txtCustName" runat="server" style="z-index: 1; left: 172px; position: absolute; top: 279px; width: 122px;"></asp:TextBox>
        <asp:TextBox ID="txtDaysNo" runat="server" style="z-index: 1; left: 176px; top: 198px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtGuestNo" runat="server" style="z-index: 1; left: 175px; top: 327px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 463px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkOK" runat="server" style="z-index: 1; left: 14px; top: 428px; position: absolute" Text="Active" />
            <asp:Label ID="lblCustName" runat="server" style="z-index: 1; left: 11px; top: 283px; position: absolute" Text="Name"></asp:Label>
            <asp:Label ID="lblGuestNo" runat="server" style="z-index: 1; left: 12px; top: 326px; position: absolute" Text="Number of Guests"></asp:Label>
            <asp:Label ID="lblDaysNo" runat="server" style="z-index: 1; left: 10px; top: 203px; position: absolute" Text="Length of stay (days)" Visible="False"></asp:Label>
            <asp:Label ID="lblCustID" runat="server" style="z-index: 1; left: 5px; top: 238px; position: absolute" Text="CustomerID"></asp:Label>
            <asp:TextBox ID="txtCustID" runat="server" style="z-index: 1; left: 174px; top: 239px; position: absolute; bottom: 304px;"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRoomID" runat="server" Text="RoomID"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <asp:TextBox ID="txtRoomID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 107px; top: 499px; position: absolute" Text="Ok" />
            <asp:Label ID="lblBookingID" runat="server" style="z-index: 1; left: 18px; top: 371px; position: absolute; height: 19px;" Text="Booking ID"></asp:Label>
            <asp:TextBox ID="txtBookingID" runat="server" style="z-index: 1; left: 180px; top: 373px; position: absolute" OnTextChanged="txtBookingId_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>
