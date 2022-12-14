<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataListForm.aspx.cs" Inherits="Tutorial_8.DataListForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center">Cats Data List From</h1>
            <br />
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" Text="Adding New Cat Name" Font-Size="Medium" ForeColor="#009900" OnClick="btnInsert_Click" />
                        <br />
                   </td>
               </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1014px" OnRowEditing="GridView1_RowEditing" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left: 5px" DataKeyNames="id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
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
    </form>
</body>
</html>
