using Assignment1.Entities.Member;
using Assignment1.Services.Member;
using System;
using System.Data;

namespace Assignment1Web.Views.Member
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSalution();
                BindRented();
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
                ddlRentedName.DataValueField = dt.Rows[0]["RentedId"].ToString();
                ddlRentedName.DataTextField = dt.Rows[0]["MovieRented"].ToString();
                ddlSalutationName.DataValueField = dt.Rows[0]["SalutationId"].ToString();
                ddlSalutationName.DataTextField = dt.Rows[0]["Salutation"].ToString();
            }
        }

        void BindRented()
        {
            MemberService memberService = new MemberService();
            DataTable dt = memberService.GetRented();
            ddlRentedName.DataSource = dt;
            ddlRentedName.DataValueField = "RentedId";
            ddlRentedName.DataTextField = "MovieRented";
            ddlRentedName.DataBind();
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
               success = memberService.Insert(memberEntity);
               btnSave.Enabled = true;
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
            memberEntity.MemberId = Convert.ToInt32(hdMemberId.Value);
            memberEntity.FullName = txtMemberName.Text;
            memberEntity.Address = txtAddressName.Text;
            memberEntity.SalutationId =Convert.ToInt32(ddlSalutationName.SelectedValue);
            memberEntity.RentedId = Convert.ToInt32(ddlRentedName.SelectedValue);
            return memberEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Member/MemberList.aspx");
        }
    }
}