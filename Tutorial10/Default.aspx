<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tutorial10._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
   <div>
       <h1 style="text-align:center">Welcome Login Page</h1>

       <br />
       <table class="nav-justified" >
           <tr>
               <td style="width: 155px; height: 20px"></td>
               <td style="height: 20px; width: 93px">
                   <asp:Label ID="lblName" runat="server" Text="User Name :"></asp:Label>
               </td>
               <td style="height: 20px">
                   <asp:TextBox ID="txtName" runat="server" Width="214px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 155px; height: 20px"></td>
               <td style="width: 93px; height: 20px">&nbsp;</td>
               <td style="height: 20px"></td>
           </tr>
           <tr>
               <td style="width: 155px; height: 20px"></td>
               <td style="width: 93px; height: 20px">Password :</td>
               <td style="height: 20px"><asp:TextBox ID="txtPassword" runat="server" Width="212px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; </td>
           </tr>
           <tr>
               <td style="width: 155px">&nbsp;</td>
               <td style="width: 93px">&nbsp;</td>
               <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
           </tr>
           <tr>
               <td style="width: 155px">&nbsp;</td>
               <td style="width: 93px">&nbsp;</td>
               <td>
                   <asp:Button ID="btnLogin" CssClass="btn btn-info" runat="server" Text="Login" />
                   &nbsp;
                   <asp:Button ID="btnForget" CssClass="btn btn-info" runat="server" Text="Forget Password" Width="161px" OnClick="btnForget_Click" />
               </td>
           </tr>
           <tr>
               <td style="width: 155px">&nbsp;</td>
               <td style="width: 93px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td style="width: 155px">&nbsp;</td>
               <td style="width: 93px">&nbsp;</td>
               <td>
                   <asp:TextBox ID="txtGmail" runat="server" placeholder="Enter Email :" Visible="false" ValidationGroup="gmailForm" Width="213px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="regEmail" runat="server" ErrorMessage="Please Filled Gamil Address" ControlToValidate="txtGmail"  ValidationGroup="gmailForm" ForeColor="#FF3300"></asp:RequiredFieldValidator>
               </td>
           </tr>
           <tr>
               <td style="width: 155px">&nbsp;</td>
               <td style="width: 93px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td style="width: 155px">&nbsp;</td>
               <td style="width: 93px">&nbsp;</td>
               <td>
                   <asp:Button ID="btnSend" CssClass="btn btn-info" runat="server" Text="Send"  ValidationGroup="gmailForm" Visible="false" OnClick="btnSend_Click" Width="65px" />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ControlToValidate="txtGmail" ErrorMessage="Please Format Gmail" ValidationGroup="gmailForm" ForeColor="#FF0066"></asp:RegularExpressionValidator>
               </td>
           </tr>
       </table>

   </div>

</asp:Content>
