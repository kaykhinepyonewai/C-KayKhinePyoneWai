<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RentList.aspx.cs" Inherits="Assignment2Web.Views.Rent.RentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container mtt rentList">
        <h1 class="title mb-5">Rent List From</h1>
        <div class="row mtt mbb">
        <div clas="col-md-12 mb-3 text-end ">
            <asp:LinkButton ID="lnkbtnNew" runat="server" CssClass="btn btn-info" OnClick="lnkbtnNew_Click">
                New Rent
            </asp:LinkButton>
        </div>
    </div>
        <div class="row">
           <div class="col-12 col-sm-12">
            <asp:GridView ID="gvRent" CssClass="table table-bordered table-striped mt-3" AutoGenerateColumns="False" runat="server" OnRowCommand="gvRent_RowCommand" OnRowDeleting="gvRent_RowDeleting" >
                    <Columns>
                        <asp:TemplateField HeaderText="Id">
                            <ItemTemplate>
                                <asp:Label ID="lblRentedId" Visible="false" runat="server" Text='<%# Eval("RentedId") %>'></asp:Label>
                                <asp:Label ID="lblRentedNo" runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Movie Rented">
                             <ItemTemplate>
                                <asp:Label ID="lblMovieRented" runat="server" Text='<%# Eval("MovieRented") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkbtnEdit" runat="server" CssClass="btn btn-success" CommandName="Edit" CommandArgument='<%# Eval("RentedId") %>'>Edit</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnDelete" runat="server" onClientClick="return fnConfirmDelete();" CssClass="btn btn-info" CommandName="Delete" CommandArgument='<%# Eval("RentedId") %>'>Delete</asp:LinkButton>
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