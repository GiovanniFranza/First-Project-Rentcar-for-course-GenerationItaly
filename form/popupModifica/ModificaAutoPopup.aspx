<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaAutoPopup.aspx.cs" Inherits="form_popupModifica_ModificaAutoPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label5" runat="server" Text="Modello: "></asp:Label>
            <asp:DropDownList ID="ddlModelli" runat="server"></asp:DropDownList>
            <br />

            <asp:Label ID="Label1" runat="server" Text="Targa: "></asp:Label>
            <asp:TextBox ID="txtTarga" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label2" runat="server" Text="Costo acquisto: "></asp:Label>
            <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label3" runat="server" Text="Prezzo mensile: "></asp:Label>
            <asp:TextBox ID="txtPrezzo" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label4" runat="server" Text="Data acquisto "></asp:Label>
            <asp:TextBox ID="txtData" runat="server" TextMode="Date"></asp:TextBox><br />

            <asp:Label ID="lblRes" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="Button1" runat="server" Text="Inserisci" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
