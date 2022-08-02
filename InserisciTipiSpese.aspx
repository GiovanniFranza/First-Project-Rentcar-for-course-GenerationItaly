<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InserisciTipiSpese.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>

    <script type="text/javascript">

    <!--$ fa riferimento al DOM , nal momento in cui il document è pronto,tieni pronte le seguenti funzioni:-->
    $(document).ready(function () {
        //per aprire popup 
        $('#popup').click(function () {

            var url = this.href;
            var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe').appendTo('body');

            // dialog può prendere impostazioni per creare dialog
            dialog.dialog({
                modal: true,
                title: 'Inserimento dati',
                resizable: false,
                width: '400px',
                overlay: { opacity: 0.9, background: 'black' },
                open: function (type, data) { $(this).parent().appendTo('form'); }


            });
            return false;
        });
    });
    </script>

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div>
        <!--link popup-->
        <a id="popup" href="form/popupInserisci/InserisciTipiSpesePopup.aspx">Inserisci</a>


        <asp:GridView ID="griglia" runat="server"></asp:GridView>
        <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" OnClick="btnAggiorna_Click" />

    </div>

</asp:Content>

