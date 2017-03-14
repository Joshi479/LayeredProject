<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LayeredProject.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 46px;
        }
        .auto-style2 {
            height: 43px;
        }
        .Red {
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <table>
                <tr>
                    <td class="auto-style2">
                        User Id:
                    </td>
                    <td class="auto-style2">
                        *
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="rfvUserID" ControlToValidate="txtUserId" runat="server" ErrorMessage="User Id is Required."></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Password:
                    </td>
                    <td class="auto-style1">
                        *
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:RequiredFieldValidator ID="rfvPassword" ControlToValidate="txtPassword" runat="server" ErrorMessage="Password is Required."></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" />
                    </td>
                    <td colspan="2">
                        * marked fields are required.
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblErrorMessage" CssClass="Red" runat="server" Enabled="false"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
