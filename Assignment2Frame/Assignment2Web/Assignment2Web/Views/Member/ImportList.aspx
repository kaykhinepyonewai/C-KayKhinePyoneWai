<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImportList.aspx.cs" Inherits="Assignment2Web.Views.Member.ExoprtList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1">
     <div class="container mtt ">
          <h1 class="title mb-5">Import List From</h1>
        <div class="row mtt mbb">
           
        <div clas="col-md-12 mb-3 text-end ">
            <div class="mbb mtt">
            <asp:FileUpload ID="FileUploadTo" cssClass="form-control mtt" ValidationGroup="gp"  runat="server" Width="305px" />
                <asp:Label ID="lblMsg" Visible="false" runat="server" ForeColor="Red"></asp:Label>
            </div>
             <asp:LinkButton ID="Import" ValidationGroup="gp" runat="server" CssClass="btn btn-info" OnClick="lnkbtnImport_Click">
                Import Data
            </asp:LinkButton>
            <asp:RequiredFieldValidator ID="revFile" ControlToValidate="FileUploadTo"  runat="server" ErrorMessage="Please Filled Excel File" ValidationGroup="gp" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </div>
        </div>
      </div>
        </form>
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