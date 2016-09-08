<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tyontekijat.aspx.cs" Inherits="tyontekijat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Työntekijät</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnHae" runat="server" Text="Hae työntekijät" OnClick="btnHae_Click"/>
        <div id="esitys">
            <h2>Työntekijä</h2>
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server" Text="..."></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>
