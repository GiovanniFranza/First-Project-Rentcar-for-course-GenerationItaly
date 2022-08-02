<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciSpesePopup.aspx.cs" Inherits="form_popupInserisci_InserisciSpesePopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <label>Spesa: </label> 
            <asp:DropDownList ID="ddlTipoSpesa" runat="server"></asp:DropDownList>
            <br />
            

            <label>Importo</label>
            <asp:TextBox ID="txtImporto" runat="server"></asp:TextBox>
            <br />


            <label>Data</label>
             <asp:TextBox ID="txtData" runat="server" TextMode="Date"></asp:TextBox>
            <br />
   

             <!--submit button -->
            <asp:Button ID="btnInvia" runat="server" Text="invia" OnClick="btnInvia_Click" />

        </div>
    </form>
</body>
</html>
