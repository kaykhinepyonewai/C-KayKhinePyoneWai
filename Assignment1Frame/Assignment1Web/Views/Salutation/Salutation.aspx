<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Salutation.aspx.cs" Inherits="Assignment1Web.Views.Salutation.Salutation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container mtt">
        <h1 class="title">Salution Entry From</h1>
        <div class="row">
             <div class="col-3 col-md-3 col-sm-3"></div>
              <asp:HiddenField ID="hdSalutationId" runat="server" Value="0" />
           <div class="col-6 col-md-6 col-sm-6">
                <div class="row">
                    <div class="col col-md-4">
                        
                        <label for="<%= txtSalutationName.ClientID  %>" class="col-form-label">Salutation Name</label>
                    </div>
                    <div class="col col-md-8">
                        <asp:TextBox ID="txtSalutationName" runat="server" ValidationGroup="namGp" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="revName" runat="server" ValidationGroup="namGp" ControlToValidate="txtSalutationName" ErrorMessage="Please Filled Name..." ForeColor="#FF3300"></asp:RequiredFieldValidator>
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
