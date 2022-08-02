<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EliminaContrattiPopup.aspx.cs" Inherits="form_popupDelete_EliminaContrattiPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
            <br />

            <asp:Button ID="btnElimina" runat="server" Text="Si" OnClick="btnElimina_Click" />
            <%--<asp:Button ID="btnEsci" runat="server" Text="No" />--%>
        </div>
    </form>
</body>
</html>
