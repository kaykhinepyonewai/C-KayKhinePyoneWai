<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="TrainingWeb.Views.Student.StudentList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title" style="text-align:center">Student List From</h1>
       <div class="row mtt mbb">
        <div clas="col-md-12 mb-3 text-end ">
            <asp:LinkButton ID="lnkbtnNew" runat="server" CssClass="btn btn-warning" OnClick="lnkbtnNew_Click">
                New
            </asp:LinkButton>
        </div>
    </div>
    
    <asp:GridView ID="gvStudent" runat="server" CssClass="table table-bordered table-striped mt-3" AutoGenerateColumns="False" OnRowCommand="gvStudent_RowCommand" OnRowDeleting="gvStudent_RowDeleting" >
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <ItemTemplate>
                   <asp:Label ID="lblStudentID" Visible="false" runat="server" Text='<%# Eval("StudentID") %>' ></asp:Label>
                     <asp:Label ID="lblStudentNo" runat="server" Text='<%#Container.DataItemIndex+1 %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                   <asp:Label ID="lblName" runat="server"  Text='<%# Eval("Name") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address">
                <ItemTemplate>
                   <asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Name">
                <ItemTemplate>
                   <asp:Label ID="lblCourseName" runat="server" Text='<%# Eval("CourseName") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Fee">
                <ItemTemplate>
                   <asp:Label ID="lblCourseFee" runat="server" Text='<%# Eval("CourseFee") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Joining Date">
                <ItemTemplate>
                   <asp:Label ID="lblJoinigDate" runat="server" Text='<%# Convert.ToDateTime(Eval("JoiningDate")).ToString("yyyy-MM-dd") %>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                   <asp:LinkButton ID="lnkbtnEdit" runat="server" CssClass="btn btn-warning btn-sm" CommandName="Edit" CommandArgument='<%# Eval("StudentID") %>'>
                       Edit
                   </asp:LinkButton>
                     <asp:LinkButton ID="lnkbtnDelete" runat="server"  CssClass="btn btn-info btn-sm" CommandName="Delete" CommandArgument='<%# Eval("StudentID") %>'>
                       Delete
                   </asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
