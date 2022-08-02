<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InserisciSpese.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

     <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            margin-top: 5px;
        }
    </style>
    <script src="script/script.js"></script>
    <script type="text/javascript">

    <!--$ fa riferimento al DOM , nal momento in cui il document è pronto,tieni pronte le seguenti funzioni:-->
    
   

    </script>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

<table> 
        <tr>
            <td>
        <!-- popup-->
        <a id="popup" class="btnPopUp" href="form/popupInserisci/InserisciSpesePopup.aspx">INSERIRE NUOVA SPESA</a>
            </td>
       </tr>
       <tr>
            <td> 
        <!-- btnaggiorna -->
         <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" OnClick="btnAggiorna_Click" />
            </td>
       </tr>
       <tr>
            <td>
        <!-- tabella -->
         <asp:GridView ID="griglia" runat="server" CellPadding="2" ForeColor="White" Width="80em" BackColor="#538ECA" BorderColor="White" BorderStyle="Solid" BorderWidth="3px" CellSpacing="5" CssClass="auto-style1" Font-Names="arial,helvetica,sans-serif" Font-Strikeout="False" Height="35px">
                    <AlternatingRowStyle BackColor="#3C80C2" />
                    <HeaderStyle BackColor="#325B96" Height="45px" />
                    <RowStyle Height="30px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    <SortedAscendingCellStyle BackColor="#3366FF" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Font-Names="arial,helvetica,sans-serif" ForeColor="White" />

                </asp:GridView>
            </td>
       </tr>
        
</table>
</asp:Content>

