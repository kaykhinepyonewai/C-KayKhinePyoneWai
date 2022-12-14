<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assignment.aspx.cs" Inherits="TrainingWeb.Views.Assignment.Assignment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container mtt">
       <asp:HiddenField ID="hdAssignmentId" runat="server" Value="0" />
         <h1 class="title" style="text-align:center">Studetn Assignment Entry From</h1>
     <div class="mb-3 row mbb">
         <div class="col-sm-3 "></div>
    <label for="<%= txtStudentName.ClientID  %>" class="col-sm-2 col-form-label">Student Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtStudentName" runat="server" ValidationGroup="group" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="revStudentName" ControlToValidate="txtStudentName" ValidationGroup="group" runat="server" ErrorMessage="Please Filled Student Name" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-sm-3 "></div>
    <label for="<%= txtTeacherName.ClientID  %>" class="col-sm-2 col-form-label">Teacher Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtTeacherName" runat="server" CssClass="form-control" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="revTeacherName" ControlToValidate="txtTeacherName" ValidationGroup="group" runat="server" ErrorMessage="Please Filled Teacher Name" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-sm-3 "></div>
    <label for="<%= txtAssignmentName.ClientID  %>" class="col-sm-2 col-form-label">Assignment Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtAssignmentName" runat="server" CssClass="form-control"  ></asp:TextBox>
        <asp:RequiredFieldValidator ID="revAssignment" ControlToValidate="txtAssignmentName" ValidationGroup="group" runat="server" ErrorMessage="Please Assignment Name" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-sm-3 "></div>
    <label for="<%= txtClassName.ClientID  %>" class="col-sm-2 col-form-label">Class Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtClassName" runat="server" CssClass="form-control" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="revClassName"  ControlToValidate="txtClassName" ValidationGroup="group" runat="server" ErrorMessage="Please Class Name" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-sm-3 "></div>
    <label for="<%= txtRemark.ClientID  %>" class="col-sm-2 col-form-label">Remark</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtRemark" runat="server" CssClass="form-control" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="revtRemark" ControlToValidate="txtRemark" ValidationGroup="group"  runat="server" ErrorMessage="Please Filled Remark" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-sm-3 "></div>
    <label for="<%= txtFinishedDate.ClientID  %>" class="col-sm-2 col-form-label">Finished Date</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtFinishedDate" runat="server" CssClass="form-control" placeholder="dd/MM/yyyy" ValidationGroup="date"></asp:TextBox>
         <asp:RequiredFieldValidator ID="revDate1" ControlToValidate="txtFinishedDate" ValidationGroup="group"  runat="server" ErrorMessage="Please Filled Date" ForeColor="Red"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator runat="server" ControlToValidate="txtFinishedDate" ValidationExpression="(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"
    ErrorMessage="Invalid date format." ValidationGroup="group" ForeColor="#FF3300" ID="revDate" />
    </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-md-5 col-sm-5">
          </div>
    <div class="col-md-6 col-sm-6">
       <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-warning" ValidationGroup="group" OnClick="btnSave_Click" />
       <asp:LinkButton ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-info" OnClick="btnCancel_Click" />
    </div>
  
  </div>
</div>
</asp:Content>