<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="Assignment2Web.Views.Member.MemberList" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container mtt salutationList">
        <h1 class="title mb-5">Member List From</h1>


          <div class="row mtt mbb">
        <div clas="col-md-12 mb-3 text-end ">
            <asp:LinkButton ID="lnkbtnExport" runat="server" CssClass="btn btn-info" OnClick="lnkbtnExport_Click">
                Export Data
            </asp:LinkButton>
            <asp:LinkButton ID="Import" ValidationGroup="gp" runat="server" CssClass="btn btn-info" OnClick="lnkbtnImport_Click">
                Import Data
            </asp:LinkButton>
            <div class="mbb mtt">
            <asp:FileUpload ID="FileUploadTo" cssClass="btn mtt" ValidationGroup="gp" runat="server" Width="305px" />
                <asp:RequiredFieldValidator ID="revFile" ControlToValidate="FileUploadTo"  runat="server" ErrorMessage="Please Filled Excel File" ValidationGroup="gp" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="Red"></asp:Label>
            </div>
            </div>
    </div>

        <div class="row">
         
            <div class="col-12 col-sm-12">
                <asp:GridView ID="gvMember" CssClass="table table-bordered table-striped mt-3" AutoGenerateColumns="False" runat="server" OnRowCommand="gvMember_RowCommand" OnRowDeleting="gvMember_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Id">
                            <ItemTemplate>
                                <asp:Label ID="lblMemberId" Visible="false" runat="server" Text='<%# Eval("MemberId") %>'></asp:Label>
                                <asp:Label ID="lblMemberNo" runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="FullName">
                             <ItemTemplate>
                                <asp:Label ID="lblFullName" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Address">
                             <ItemTemplate>
                                <asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="MovieRented">
                             <ItemTemplate>
                               
                        <asp:Label ID="lblMovieRented" runat="server" Text='<%# Eval("MovieRented") %>'></asp:Label>
                            <asp:Label ID="lblRentedId" Visible="false" runat="server" Text='<%# Eval("RentedId") %>'></asp:Label>    
                             </ItemTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Salutation">
                             <ItemTemplate>
                               
                 <asp:Label ID="lblSalutation" runat="server" Text='<%# Eval("Salutation") %>'></asp:Label>
                                <asp:Label ID="lblSalutationId" Visible="false" runat="server" Text='<%# Eval("SalutationId") %>'></asp:Label>
                             </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkbtnEdit" runat="server" CssClass="btn btn-success" CommandName="Edit" CommandArgument='<%# Eval("MemberId") %>'>Edit</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnDelete" runat="server" CssClass="btn btn-info" onClientClick="return fnConfirmDelete();" CommandName="Delete" CommandArgument='<%# Eval("MemberId") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>


     <script language="javascript" type="text/javascript">
         $(function () {
             $('[id*=FileUploadTo]').on('focus', function () {
                 $('[id*=lblMsg]').html('');
                 $('[id*=lblMsg]').hide();
             });
         });

        function fnConfirmDelete() {
            return confirm("Are you sure you want to delete this?");
        }
     </script>

</asp:Content>