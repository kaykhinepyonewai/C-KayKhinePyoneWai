<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="Assignment1Web.Views.Member.MemberList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container mtt salutationList">
        <h1 class="title mb-5">Member List From</h1>

        <div class="row">
         
            <div class="col-12 col-sm-12">
                <asp:LinkButton ID="lnkbtnNew" CssClass="btn btn-info" runat="server" OnClick="lnkbtnNew_Click">New Member</asp:LinkButton>
              
                <asp:GridView ID="gvMember" CssClass="table table-bordered table-striped mt-3" AutoGenerateColumns="False" runat="server" OnRowCommand="gvMember_RowCommand" OnRowDeleting="gvMember_RowDeleting">
                    <Columns>
                        <asp:TemplateField HeaderText="Id">
                            <ItemTemplate>
                                <asp:Label ID="lblMemberId" runat="server" Text='<%# Eval("MemberId") %>'></asp:Label>
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
                         <asp:TemplateField HeaderText="Salutation">
                             <ItemTemplate>
                               
                                <asp:Label ID="lblSalutation" runat="server" Text='<%# Eval("Salutation") %>'></asp:Label>
                                
                             </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkbtnEdit" runat="server" CssClass="btn btn-success" CommandName="Edit" CommandArgument='<%# Eval("MemberId") %>'>Edit</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnDelete" runat="server" CssClass="btn btn-info" CommandName="Delete" CommandArgument='<%# Eval("MemberId") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                    </Columns>

                </asp:GridView>


            </div>
        </div>

    </div>

</asp:Content>