<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ModificaModelli.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.13.1/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>
    <script src="script/script.js"></script>

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div>

        <!-- popup-->
        <div id="nascondi" runat="server">
            <a id="popup" class="ui-button ui-widget ui-corner-all" href="form/popupModifica/ModificaModelliPopup.aspx">Inserisci</a>
        </div>

        <!-- griglia -->
        <asp:GridView ID="griglia" runat="server" AutoGenerateSelectButton="True" DataKeyNames="codiceMarca,codiceModello" OnSelectedIndexChanged="griglia_SelectedIndexChanged"></asp:GridView>


        <!-- btnaggiorna -->
        <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" OnClick="btnAggiorna_Click" />

    </div>


</asp:Content>

