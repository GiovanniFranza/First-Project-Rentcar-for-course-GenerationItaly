<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaModelliPopup.aspx.cs" Inherits="form_popupModifica_ModificaModelliPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <!-- ddl marche -->
            <label>
                Marca: 
            </label>
            <asp:DropDownList ID="ddlMarche" runat="server"></asp:DropDownList>
            <br/>


            <label>
                Modello: 
            </label>
            <asp:TextBox ID="txtModello" runat="server"></asp:TextBox>
            <br/>

            <asp:Label ID="lblRes" runat="server" Text=""></asp:Label>
            <br />

            <!-- bottone -->
            <asp:Button ID="btnInserisci" runat="server" Text="Ok" OnClick="btnInserisci_Click" />

        </div>
    </form>
</body>
</html>
