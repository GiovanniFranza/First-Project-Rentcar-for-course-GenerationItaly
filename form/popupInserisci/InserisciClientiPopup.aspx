<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciClientiPopup.aspx.cs" Inherits="form_popupInserisci_InserisciClientiPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <label>
                Ragione sociale:
            </label>
            <asp:TextBox ID="txtRagioneSociale" runat="server"></asp:TextBox>
            <br />


            <label>
                Partita iva:
            </label>
            <asp:TextBox ID="txtPartitaIva" runat="server"></asp:TextBox>
            <br />


            <label>
                Cdice fiscale:
            </label>
            <asp:TextBox ID="txtCodiceFiscale" runat="server"></asp:TextBox>
            <br />


            <label>
                Indirizzo:
            </label>
            <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
            <br />


            <label>
                CAP:
            </label>
            <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
            <br />


            <label>
                Città:
            </label>
            <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
            <br />



            <label>
                Provincia:
            </label>
            <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
            <br />


            <asp:Button ID="btnInserisci" runat="server" Text="inserisci" OnClick="btnInserisci_Click" />

        </div>
    </form>
</body>
</html>
