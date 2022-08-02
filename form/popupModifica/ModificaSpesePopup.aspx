<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaSpesePopup.aspx.cs" Inherits="form_popupModifica_ModificaSpesePopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <asp:Label ID="lblCodiceTipoSpesa" runat="server" Text="Tipo spesa: "></asp:Label>
        <asp:DropDownList ID="ddlTipoSpesa" runat="server"></asp:DropDownList>
        <be />

        <asp:Label ID="lblImporto" runat="server" Text="Importo: "></asp:Label>
        <asp:TextBox ID="txtImporto" runat="server"></asp:TextBox>

        <asp:Label ID="lblData" runat="server" Text="Data: "></asp:Label>
        <asp:TextBox ID="txtData" runat="server" TextMode="Date"></asp:TextBox>
        <br />

        <asp:Label ID="lblRes" runat="server" Text=""></asp:Label>
        <br />


        <asp:Button ID="btnInvia" runat="server" Text="Ok" OnClick="btnInvia_Click" />

    </form>
</body>
</html>
