<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="Tutorial10.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="lib/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />


    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 170px;
        }
        .auto-style5 {
            width: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center">Welcome To Reset Passwrod Page</h1>
           
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label runat="server" Text="New Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNewPass" runat="server" Width="154px" TextMode="Password" ValidationGroup="newPassGp"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblConfiPass" runat="server" Text="Confirm Password" TextMode="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPass" runat="server" Width="156px" TextMode="Password" ValidationGroup="confirmGp"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="revConfPass" runat="server" ControlToValidate="txtConfirmPass" ErrorMessage="Please Filled Confirm Password" Font-Size="Small" ForeColor="#FF3300" ValidationGroup="confirmGp"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:Button ID="btnUpdate" CssClass="btn btn-info" runat="server" OnClick="btnClick" Text="Update" ValidationGroup="newPassGp" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="revNewPass" runat="server" ErrorMessage="Please Filled New Password " ControlToValidate="txtNewPass" Font-Size="Small" ForeColor="#FF3300" ValidationGroup="newPassGp"></asp:RequiredFieldValidator>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <script src="lib/bootstrap/js/bootstrap.js"></script>
    <script src="lib/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
