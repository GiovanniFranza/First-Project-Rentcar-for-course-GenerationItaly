<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <table>
                <!-- text username  password -->
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Username"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>

                    <!-- textBox username  password -->
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPsw" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPsw" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <!-- button login and register -->
                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Registrati" OnClick="btnRegister_Click" />

                    </td>

                </tr>
            </table>
        </div>
    </form>
</body>
</html>
