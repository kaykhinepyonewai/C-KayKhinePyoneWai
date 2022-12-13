<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tutorial7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <div>
      <h1 class="text-align:center">Welcome To Login Page</h1>
      <asp:Label ID="errorMSG" runat="server" Text=""></asp:Label>
      <br /><br />
      <asp:Label ID="Label1" runat="server" Text="Gamil"></asp:Label>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="txtGamil" runat="server"></asp:TextBox>
      &nbsp;&nbsp;
    
     &nbsp;
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Fill Gmail" ControlToValidate="txtGamil" ForeColor="#FF0066"></asp:RequiredFieldValidator>
        &nbsp;  &nbsp; 
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ControlToValidate="txtGamil" ErrorMessage="Please Format Gmail" ForeColor="#FF0066"></asp:RegularExpressionValidator>
      <br />
      <br />
      
      <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
       &nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox> &nbsp; &nbsp;   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Fill Correct Password" ControlToValidate="txtPassword" ForeColor="#FF0066"></asp:RequiredFieldValidator>
      <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
      &nbsp;<br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

  </div>



</asp:Content>
