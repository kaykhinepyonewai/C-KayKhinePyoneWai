<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignmetnList.aspx.cs" Inherits="TrainingWeb.Views.Assignment.AssignmetnList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1 class="title" style="text-align:center">Student Assignment List From</h1>
        <div class="row mtt mbb">
        <div clas="col-md-12 mb-3 text-end ">
            <asp:LinkButton ID="lnkbtnNew" runat="server" CssClass="btn btn-warning" OnClick="lnkbtnNew_Click">
                New
            </asp:LinkButton>
        </div>
    </div>

     <asp:GridView ID="gvAssignment" runat="server" CssClass="table table-bordered table-striped mt-3" AutoGenerateColumns="False" OnRowCommand="gvAssignment_RowCommand" OnRowDeleting="gvAssignment_RowDeleting" OnSelectedIndexChanged="gvAssignment_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                   <asp:Label ID="lblAssignmentId" runat="server" Text='<%# Eval("AssignmentId") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                   <asp:Label ID="lblStudentName" runat="server" Text='<%# Eval("StudentName") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Teacher Name">
                <ItemTemplate>
                   <asp:Label ID="lblTeacherName" runat="server" Text='<%# Eval("TeacherName") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Assignment Name">
                <ItemTemplate>
                   <asp:Label ID="lblAssignmentName" runat="server" Text='<%# Eval("AssignmentName") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Class Name">
                <ItemTemplate>
                   <asp:Label ID="lblClassName" runat="server" Text='<%# Eval("ClassName") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           <asp:TemplateField HeaderText="Remark">
                <ItemTemplate>
                   <asp:Label ID="lblRemark" runat="server" Text='<%# Eval("Remark") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Finished Date">
                <ItemTemplate>
                   <asp:Label ID="lblFinishedDate" runat="server" Text='<%# Convert.ToDateTime(Eval("FinishedDate")).ToString("yyyy-MM-dd") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                   <asp:LinkButton ID="lnkbtnEdit" runat="server" CssClass="btn btn-warning btn-sm" CommandName="Edit" CommandArgument='<%# Eval("AssignmentId") %>'>
                       Edit
                   </asp:LinkButton>
                     <asp:LinkButton ID="lnkbtnDelete" runat="server"  CssClass="btn btn-info btn-sm" CommandName="Delete" CommandArgument='<%# Eval("AssignmentId") %>'>
                       Delete
                   </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

  </asp:Content>
