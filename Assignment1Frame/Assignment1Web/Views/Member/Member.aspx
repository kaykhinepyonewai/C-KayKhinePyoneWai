<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Assignment1Web.Views.Member.Member" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container mtt">
        <h1 class="title">Member Entry From</h1>
        <div class="row">
             <div class="col-3 col-md-3 col-sm-3"></div>
              <asp:HiddenField ID="hdMemberId" runat="server" Value="0" />
           <div class="col-6 col-md-6 col-sm-6">
                <div class="row">
                    <div class="col col-md-4">
                        
                        <label for="<%= txtMemberName.ClientID  %>" class="col-form-label">Member Full Name</label>
                    </div>
                    <div class="col col-md-8">
                        <asp:TextBox ID="txtMemberName" runat="server" ValidationGroup="namGp" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="revName" runat="server" ValidationGroup="namGp" ControlToValidate="txtMemberName" ErrorMessage="Please Filled Name..." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="row">
                    <div class="col col-md-4">
                        
                        <label for="<%= txtAddressName.ClientID  %>" class="col-form-label">Address</label>
                    </div>
                    <div class="col col-md-8">
                        <asp:TextBox ID="txtAddressName" runat="server" ValidationGroup="namGp" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="revAddress" runat="server" ValidationGroup="namGp" ControlToValidate="txtAddressName" ErrorMessage="Please Filled Address..." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>
                </div>

               <div class="row">
                    <div class="col col-md-4">
                        <label for="<%= textRentedId.ClientID  %>" Visible="false" class="col-form-label"></label>
                        <label for="<%= ddlRentedName.ClientID  %>" class="col-form-label">Movie Rented</label>
                    </div>
                    <div class="col col-md-8">
                        <asp:TextBox ID="textRentedId" Visible="false" runat="server" ValidationGroup="namGp" CssClass="form-control"></asp:TextBox>
                        <asp:DropDownList ID="ddlRentedName"  runat="server" cssClass="col-form col-md-12"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="revRetnedName" runat="server" ValidationGroup="namGp" ControlToValidate="ddlRentedName" ErrorMessage="Please Filled Address..." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>
                </div>

                 <div class="row">
                    <div class="col col-md-4">
                        <label for="<%= txtSalutationId.ClientID  %>" Visible="false" class="col-form-label"></label>
                        <label for="<%= ddlSalutationName.ClientID  %>" class="col-form-label">Salutation Name</label>
                    </div>
                    <div class="col col-md-8">
                        <asp:TextBox ID="txtSalutationId" Visible="false" runat="server" ValidationGroup="namGp" CssClass="form-control"></asp:TextBox>
                        <asp:DropDownList ID="ddlSalutationName"  runat="server" cssClass="col-form col-md-12"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="revSalutation" runat="server" ValidationGroup="namGp" ControlToValidate="ddlSalutationName" ErrorMessage="Please Filled Address..." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="row buttonAll">
                    <div class="col col-md-4"><asp:Label ID="lblMessage" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label></div>
                    <div class="col col-md-8">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" ValidationGroup="namGp" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                    </div>
                </div>

            </div>
           
        </div>
    </div>

    <script type="text/javascript">
        $(function () {
            $('[id*=txtSalutationName]').on('focus', function () {
                $('[id*=lblMessage]').html('');
                $('[id*=lblMessage]').hide();
            });
        });
    </script>

</asp:Content>