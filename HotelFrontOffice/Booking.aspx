<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Booking.aspx.cs" Inherits="Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 252px">
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Button ID="BtnCancel" runat="server" OnClick="Button2_Click" style="z-index: 1; position: absolute; top: 258px; left: 10px;" Text="Cancel" />
        </div>
        <asp:TextBox ID="txtDaysNo" runat="server" style="z-index: 1; left: 341px; top: 306px; position: absolute" Height="20px"></asp:TextBox>
        <asp:TextBox ID="txtGuestNo" runat="server" style="z-index: 1; left: 340px; top: 358px; position: absolute" Height="20px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 493px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkOK" runat="server" style="z-index: 1; left: 351px; top: 458px; position: absolute" Text="Active" />
            <asp:Label ID="lblRoomID" runat="server" style="z-index: 1; left: 192px; top: 418px; position: absolute; right: 1227px;" Text="Room Number"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCustID" runat="server" style="z-index: 1; left: 220px; top: 200px; position: absolute; right: 1215px; height: 19px;" Text="CustomerID"></asp:Label>
        </p>
        <p>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 13px; top: 310px; position: absolute" Text="Ok" />
            <asp:Label ID="lblBookingID" runat="server" style="z-index: 1; left: 221px; top: 149px; position: absolute; height: 19px;" Text="Booking ID"></asp:Label>
            <asp:TextBox ID="txtBookingID" runat="server" style="z-index: 1; left: 342px; top: 144px; position: absolute" OnTextChanged="txtBookingId_TextChanged" Height="20px" ReadOnly="True"></asp:TextBox>
        </p>
        <p style="height: 354px">
            <asp:Button ID="k" runat="server" OnClick="btnFind_Click" Text="Find" />
        <asp:TextBox ID="txtRoom" runat="server" style="z-index: 1; left: 345px; top: 411px; position: absolute" Height="20px"></asp:TextBox>
            <asp:Label ID="lblGuestNo" runat="server" style="z-index: 1; left: 182px; top: 362px; position: absolute" Text="Number of Guests"></asp:Label>
            <asp:Label ID="lblCustName" runat="server" style="z-index: 1; left: 212px; top: 261px; position: absolute; height: 19px;" Text="Name"></asp:Label>
            <asp:Label ID="lblDaysNo" runat="server" style="z-index: 1; left: 176px; top: 310px; position: absolute" Text="Duration of stay (Days)"></asp:Label>
            <asp:TextBox ID="txtCustName" runat="server" style="z-index: 1; left: 344px; top: 255px; position: absolute; bottom: 421px;" Height="20px" OnTextChanged="txtCustID_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtCustID" runat="server" style="z-index: 1; left: 341px; top: 197px; position: absolute" Height="20px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
