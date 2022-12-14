<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalutationList.aspx.cs" Inherits="Assignment1Web.Views.Salutation.SalutationList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container mtt salutationList">
        <h1 class="title mb-5">Salution List From</h1>

          <div class="row mtt mbb">
        <div clas="col-md-12 mb-3 text-end ">
            <asp:LinkButton ID="lnkbtnNew" runat="server" cssClass="btn btn-info" OnClick="lnkbtnNew_Click">
                New Salutation
            </asp:LinkButton>
        </div>
    </div>



        <div class="row">
            
            <div class="mbb col-12 col-sm-12">
                <asp:GridView ID="gvSalutation" CssClass="table table-bordered table-striped mt-3" AutoGenerateColumns="False" runat="server" OnRowCommand="gvSalutation_RowCommand" OnRowDeleting="gvSalutation_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Id">
                            <ItemTemplate>
                                <asp:Label ID="lblSalutationId" Visible="false" runat="server" Text='<%# Eval("SalutationId") %>'></asp:Label>
                                 <asp:Label ID="lblSalutationNo" runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                 
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Salutation Name">
                             <ItemTemplate>
                       
                                <asp:Label ID="lblSaultationName" runat="server" Text='<%# Eval("Salutation") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkbtnEdit" runat="server" CssClass="btn btn-success" CommandName="Edit" CommandArgument='<%# Eval("SalutationId") %>'>Edit</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnDelete" runat="server" CssClass="btn btn-info" onClientClick="return fnConfirmDelete();" CommandName="Delete" CommandArgument='<%# Eval("SalutationId") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>

    </div>

    <script language="javascript" type="text/javascript">
        function fnConfirmDelete() {
            return confirm("Are you sure you want to delete this?");
        }
    </script>
</asp:Content>