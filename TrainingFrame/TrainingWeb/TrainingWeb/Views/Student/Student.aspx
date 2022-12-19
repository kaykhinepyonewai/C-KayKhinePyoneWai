<%@ Page Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="TrainingWeb.Views.Student.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container mtt">
            <asp:HiddenField ID="hdStudentId" runat="server" Value="0" />
       <div class="mb-3 row mbb">
    <label for="<%= txtName.ClientID  %>" class="col-sm-2 col-form-label">Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
    <label for="<%= txtAddress.ClientID  %>" class="col-sm-2 col-form-label">Address</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" TextMode="MultiLine" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
    <label for="<%= txtCourseName.ClientID  %>" class="col-sm-2 col-form-label">Course Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtCourseName" runat="server" CssClass="form-control" placeholder="Asp.net or Java or Php or Nodejs" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
    <label for="<%= txtCourseFee.ClientID  %>" class="col-sm-2 col-form-label">Course Fee</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtCourseFee" runat="server" CssClass="form-control" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
    <label for="<%= txtJoiningDate.ClientID  %>" class="col-sm-2 col-form-label">Joining Date</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtJoiningDate" runat="server" CssClass="form-control" placeholder="dd/MM/yyyy" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-md-2">
          </div>
    <div class="col-md-6">
       <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
       <asp:LinkButton ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
    </div>
  
  </div>
</div>
 
</asp:Content>