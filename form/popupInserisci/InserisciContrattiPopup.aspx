<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciContrattiPopup.aspx.cs" Inherits="form_popupInserisci_InserisciContrattiPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="ddlClienti" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="ddlAuto" runat="server"></asp:DropDownList><br />
            <asp:TextBox ID="txtDataInizio" runat="server" TextMode="Date"></asp:TextBox><br />
            <asp:TextBox ID="txtdataFine" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />

        </div>
    </form>
</body>
</html>
