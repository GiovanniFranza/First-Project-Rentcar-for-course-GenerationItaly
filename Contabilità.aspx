<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contabilità.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       <!-- ddl anni -->
        <div>
            <asp:DropDownList ID="ddlAnno" runat="server">
                
            </asp:DropDownList>
            <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />

        </div>

        <div>
            <!-- somma spese, dell'anno ( a scelta da ddl) -->
            <asp:Label ID="Label1" runat="server" Text="Somma spese per anno:"></asp:Label>
            <asp:Label ID="lblSommaSpese" runat="server" Text="Label"></asp:Label>
        </div>


        <div>
            <!-- somma locazioni (anno scelto su ddl) -->
            <asp:Label ID="Label2" runat="server" Text="Somma locazioni per anno: "></asp:Label>
            <asp:Label ID="lblSommaLocazioni" runat="server" Text=""></asp:Label>

        </div>

        <div>
            <!-- differenza tra spese e locazioni: Bilancio -->
            <asp:Label ID="Label3" runat="server" Text="Bilancio: "></asp:Label>
            <asp:Label ID="lblBilancio" runat="server" Text=""></asp:Label>

        </div>
        <!--tabella con spese per mese -->   
            <asp:GridView ID="giglia" runat="server"></asp:GridView>
</asp:Content>

