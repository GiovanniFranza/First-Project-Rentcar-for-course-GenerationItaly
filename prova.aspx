<%@ Page Language="C#" AutoEventWireup="true" CodeFile="prova.aspx.cs" Inherits="prova" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <!-- ddl anni -->
        <div>
            <asp:DropDownList ID="ddlAnno" runat="server">
                
            </asp:DropDownList>
            <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />

        </div>

        <div>
            <!-- somma spese a scelta dell'anno ( a scelta da ddl) -->
            <asp:Label ID="Label1" runat="server" Text="Somma spese per anno:"></asp:Label>
            <asp:Label ID="lblSommaSpese" runat="server" Text="Label"></asp:Label>
        </div>


        <div>
            <!-- somma locazioni a scelta dell'anno -->
            <asp:Label ID="Label2" runat="server" Text="Somma locazioni per anno: "></asp:Label>
            <asp:Label ID="lblSommaLocazioni" runat="server" Text=""></asp:Label>

        </div>

        <div>
            <!-- differenza tra spese e locazioni-->
            <asp:Label ID="Label3" runat="server" Text="Bilancio: "></asp:Label>
            <asp:Label ID="lblBilancio" runat="server" Text=""></asp:Label>

        </div>
        <!--tabella con spese per mese -->
        <div>
            <asp:Literal ID="litMesi" runat="server"></asp:Literal>

        </div>

        
            <asp:GridView ID="giglia" runat="server"></asp:GridView>
        
    </form>
</body>
</html>
