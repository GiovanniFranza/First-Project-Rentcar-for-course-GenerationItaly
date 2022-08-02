<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciModelliPopup.aspx.cs" Inherits="form_popupInserisci_InserisciModelliPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              
               <!-- dropdownlist marche -->
               <label>Marca: </label>
                <asp:DropDownList ID="ddlMarche" runat="server"></asp:DropDownList>
                <br />
                
            
                <!--Textbox descrizione-->
                <label>Descrizione:</label>
                <asp:TextBox ID="txtDescrizione" runat="server"></asp:TextBox>
                <br />

                    
                 <asp:Button ID="btnInserisci" runat="server" Text="Crea" OnClick="btnInserisci_Click" />
            
        </div>
    </form>
</body>
</html>
