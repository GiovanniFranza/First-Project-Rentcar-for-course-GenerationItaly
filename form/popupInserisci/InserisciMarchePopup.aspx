<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciMarchePopup.aspx.cs" Inherits="form_popupInserisci_InserisciMarchePopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <!--Textbox descrizione-->
                <label>Marca: </label> 
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
           
                <asp:Button ID="btnInserisciMarca" runat="server" Text="Inserisci marca" OnClick="btnInserisciMarca_Click" />
            
        
        </div>
    </form>
</body>
</html>
