<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Tutorial7.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome To Home Page </h1>
            <asp:PlaceHolder ID="LogoutPlaceHolder1" runat="server" Visible="false">
            <b>Your Email Address: <%=HttpContext.Current.Session["Email"] %></b>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogout" runat="server" Text="Logout" ForeColor="#FF3300" OnClick="btnLogout_Click" />
             </asp:PlaceHolder>

             <asp:PlaceHolder ID="LoginPlaceHolder1" runat="server" Visible="false">
                 <h2>Please Go To Login Page</h2>
                 <asp:Button ID="btnLogin" runat="server" Text="Login" ForeColor="#FF3300" OnClick="btnLogin_Click" />
             </asp:PlaceHolder>

        </div>
    </form>
</body>
</html>
