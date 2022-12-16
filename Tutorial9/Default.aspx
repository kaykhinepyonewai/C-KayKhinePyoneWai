<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tutorial9._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
   <div>
       <h1 style="text-align:center">Importing Text & Excel & CSV File To GridView</h1>

   </div>

    <br />
    <table class="nav-justified">
        <tr>
            <td style="width: 355px; height: 42px;">
                <asp:FileUpload ID="FileUploadTo" runat="server" Width="305px" />
                <br />
            </td>
            <td style="width: 498px; height: 42px;"><asp:Button ID="btnUpload" CssClass="btn btn-info" runat="server" Text="Upload File" OnClick="btnUpload_Click" style="margin-left: 20" /></td>
            <td style="height: 42px"></td>
        </tr>
        <tr>
            <td style="width: 355px; height: 20px">
                <asp:Label ID="lblMsg" runat="server" Text="" Visible="False" ForeColor="#FF3300"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUploadTo" ValidationGroup="" ErrorMessage="Please Choose Text file || Excel File || CSV File" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 498px; height: 20px"></td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="width: 355px">&nbsp;</td>
            <td style="width: 498px"><asp:GridView ID="GridView1" runat="server" Width="99%" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
