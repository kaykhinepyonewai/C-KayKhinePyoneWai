using Assignment1.Services.Member;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Assignment1Web.Views.Member
{
    public partial class MemberList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            MemberService memberService = new MemberService();
            DataTable dt = memberService.GetAll();

            gvMember.DataSource = dt;
            gvMember.DataBind();
        }

        protected void lnkbtnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Member/Member.aspx");
        }

        protected void gvMember_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("~/Views/Member/Member.aspx?id=" + e.CommandArgument);

            }
        }

        protected void gvMember_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblMemberId = (Label)gvMember.Rows[e.RowIndex].FindControl("lblMemberId");
            MemberService memberService = new MemberService();
            bool success = memberService.Delete(Convert.ToInt32(lblMemberId.Text));

            if (success)
            {
                BindData();
            }
           
        }

      
    }
}