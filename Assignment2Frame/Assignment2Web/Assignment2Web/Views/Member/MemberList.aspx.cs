using Assignment2.Services.Member;
using System;
using System.Data;
using System.Web;
using System.Web.UI;
using OfficeOpenXml;
using System.Web.UI.WebControls;
using OfficeOpenXml.Table;

namespace Assignment2Web.Views.Member
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
        protected void lnkbtnImport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Member/ImportList.aspx");
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

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

        protected void lnkbtnExport_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Charset = "";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment;filename=MemberList.xlsx");

            MemberService memberService = new MemberService();
            DataTable dt = memberService.GetAllExport();

            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet wsDt = pck.Workbook.Worksheets.Add("Historique");
                wsDt.Cells["A1"].LoadFromDataTable(dt, true, TableStyles.Light20);
                wsDt.Cells.AutoFitColumns();
                Response.BinaryWrite(pck.GetAsByteArray());
            }

            Response.Write("<script>alert('MemberList Excel has been Saved To Download Location') </script>");
            Response.Flush();
            Response.End();
        }

        protected void lnkbtnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Member/Member.aspx");
        }
    }
    }
