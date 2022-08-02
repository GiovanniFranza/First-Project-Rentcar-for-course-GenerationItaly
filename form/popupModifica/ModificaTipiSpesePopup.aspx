<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaTipiSpesePopup.aspx.cs" Inherits="form_popupModifica_ModificaTipiSpese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Show codSpesa to delete-->
            <asp:Label ID="lblCodSpesa" runat="server" Text=""></asp:Label>
            <label>
                Tipo spesa: 
            </label>
            <asp:TextBox ID="txtTipoSpesa" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblRes" runat="server" Text=""></asp:Label>
            <br/>

            <asp:Button ID="btnInserisci" runat="server" Text="Ok" OnClick="btnInserisci_Click" />
        </div>
    </form>
</body>
</html>
