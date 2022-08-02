<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaMarchePopup.aspx.cs" Inherits="form_popupModifica_ModificaMarche" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="lblres" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="btnMarca" runat="server" Text="Modifica Marca" OnClick="btnMarca_Click" />

        </div>
    </form>
</body>
</html>
