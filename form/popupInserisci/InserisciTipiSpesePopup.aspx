<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciTipiSpesePopup.aspx.cs" Inherits="form_popupInserisci_InserisciTipiSpesePopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:TextBox ID="txtTipoSpesa" runat="server"></asp:TextBox>
             <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />
        </div>
    </form>
</body>
</html>
