<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tutorial_8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="dogs">
        <h1 style="text-align:center;margin-bottom:10px" >Cat Informations Managment System</h1>
        
        <table class="nav-justified">
            <tr>
                <td style="width: 235px; height: 36px;">
                    
                </td>
                <td style="height: 36px; width: 181px">
                    <asp:Label ID="lblCat" runat="server" Text="Cat Name : " CssClass="name" ForeColor="Black"></asp:Label>
                </td>
                <td style="height: 36px">
                    <asp:TextBox ID="txtName" runat="server" Width="199px" ValidationGroup="entryForm"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="revCatName" runat="server" ControlToValidate="txtName" ValidationGroup="entryForm" ErrorMessage="Please Filled Cat Name" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 235px; height: 57px;"></td>
                <td style="height: 57px; width: 181px"></td>
                <td style="height: 57px">
                    <asp:Button ID="btnInsert" runat="server" ForeColor="#009933" Text="Insert Data" ValidationGroup="entryForm" OnClick="btnInsert_Click" />
                   &nbsp;&nbsp;<asp:Label ID="lbName" runat="server" Text="Name is already Exit...." Visible="False" ValidationGroup="entryForm" ControlToValidate="txtName" ForeColor="#FF0066"></asp:Label> 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   
                    </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 235px">&nbsp;</td>
                <td style="width: 181px">&nbsp;</td>
                <td>
                     <asp:GridView ID="gvList" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1014px" OnRowEditing="gvList_RowEditing" OnRowUpdating="gvList_RowUpdating" style="margin-left: 5px" DataKeyNames="id" OnRowCancelingEdit="gvList_RowCancelingEdit" OnRowDeleting="gvList_RowDeleting">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="Id" ReadOnly="True" />
                            <asp:BoundField DataField="name" HeaderText="Cat Name" />
                            <asp:CommandField ButtonType="Button" HeaderText="Action" ShowEditButton="True" />
                            <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True"/>
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                </td>
            </tr>
            </table>
    </div>
    <script src="lib/jquery/jquery.js"></script>
    <script type="text/javascript">
        $(function () {
            $('[id*=txtName]').on('focus', function () {
                $('[id*=lbName]').html('');
                $('[id*=lbName]').hide();
            });
        });
    </script>
</asp:Content>
