﻿<%@ Page Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="TrainingWeb.Views.Student.Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container mtt">
            <asp:HiddenField ID="hdStudentId" runat="server" Value="0" />
            <h1 class="title" style="text-align:center">Studetn Entry From</h1>
       <div class="mb-3 row mbb">
            <div class="col-sm-3 "></div>
    <label for="<%= txtName.ClientID  %>" class="col-sm-2 col-form-label">Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
       <div class="col-sm-3 "></div>
    <label for="<%= txtAddress.ClientID  %>" class="col-sm-2 col-form-label">Address</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" TextMode="MultiLine" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
       <div class="col-sm-3 "></div>
    <label for="<%= txtCourseName.ClientID  %>" class="col-sm-2 col-form-label">Course Name</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtCourseName" runat="server" CssClass="form-control" placeholder="Asp.net or Java or Php or Nodejs" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
       <div class="col-sm-3 "></div>
    <label for="<%= txtCourseFee.ClientID  %>" class="col-sm-2 col-form-label">Course Fee</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtCourseFee" runat="server" CssClass="form-control" required></asp:TextBox>
    </div>
  </div>
  <div class="mb-3 row mbb">
       <div class="col-sm-3 "></div>
    <label for="<%= txtJoiningDate.ClientID  %>" class="col-sm-2 col-form-label">Joining Date</label>
    <div class="col-sm-5">
      <asp:TextBox ID="txtJoiningDate" runat="server" CssClass="form-control" placeholder="dd/MM/yyyy" ValidationGroup="date" required></asp:TextBox>
          <asp:RegularExpressionValidator runat="server" ControlToValidate="txtJoiningDate" ValidationExpression="(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"
    ErrorMessage="Invalid date format." ValidationGroup="date" ID="revDate" ForeColor="#FF3300" />
    </div>
  </div>
  <div class="mb-3 row mbb">
      <div class="col-md-5 col-sm-5">
          </div>
    <div class="col-md-6">
       <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-warning" ValidationGroup="date" OnClick="btnSave_Click" />
       <asp:LinkButton ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-info" OnClick="btnCancel_Click" />
      
    </div>
  </div>
</div>
</asp:Content>