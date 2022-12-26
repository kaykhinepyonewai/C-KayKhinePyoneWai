using Assignment1.Entities.Member;
using Assignment1.Entities.Salutation;
using Assignment1.Services.Member;
using Assignment1.Services.Salutation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1Web.Views.Member
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSalution();
                if (Request.QueryString["id"] != null)
                {
                    hdMemberId.Value = Request.QueryString["id"].ToString();
                    BindData();
                    btnSave.Text = "Update";
                }
                btnSave.Enabled = true;
                
            }
        }

        void BindData()
        {
            MemberService memberService = new MemberService();
            DataTable dt = memberService.Get(Convert.ToInt32(hdMemberId.Value));
            if (dt.Rows.Count > 0)
            {
                txtMemberName.Text = dt.Rows[0]["FullName"].ToString();
                txtAddressName.Text = dt.Rows[0]["Address"].ToString();
                ddlSalutationName.DataValueField = dt.Rows[0]["SalutationId"].ToString();
                ddlSalutationName.DataTextField = dt.Rows[0]["Salutation"].ToString();
            }
        }

        void BindSalution()
        {
            MemberService memberService = new MemberService();
            DataTable dt = memberService.GetSalutation();
            ddlSalutationName.DataSource = dt;
            ddlSalutationName.DataValueField = "SalutationId";
            ddlSalutationName.DataTextField = "Salutation";
            ddlSalutationName.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AddorUpdate();
        }

        void AddorUpdate()
        {
            MemberService memberService = new MemberService();
            MemberEntity memberEntity = CreateData();
            bool success = false;
            if (hdMemberId.Value == "0")
            {
                int count = 0;
                count = memberService.Count(memberEntity);
                if (count > 0)
                {
                    btnSave.Enabled = false;
                    lblMessage.Text = "Name is Already Exit......";
                    lblMessage.Visible = true;
                }
                else
                {
                    btnSave.Enabled = true;
                    lblMessage.Visible = true;
                    success = memberService.Insert(memberEntity);
                }

                btnSave.Enabled = true;
                //txtSalutationName.Text = "";

            }
            else
            {
                success = memberService.Update(memberEntity);
            }

            if (success)
            {
                Response.Redirect("~/Views/Member/MemberList.aspx");
            }
        }


        public MemberEntity CreateData()
        {
            MemberEntity memberEntity = new MemberEntity();
            memberEntity.memberid = Convert.ToInt32(hdMemberId.Value);
            memberEntity.fullname = txtMemberName.Text;
            memberEntity.address = txtAddressName.Text;
            memberEntity.salutationid =Convert.ToInt32(ddlSalutationName.SelectedValue);
            return memberEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Member/MemberList.aspx");
        }
    }
}