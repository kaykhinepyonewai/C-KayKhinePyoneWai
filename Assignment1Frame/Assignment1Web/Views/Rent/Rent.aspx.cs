using Assignment1.Entities.Rent;
using Assignment1.Services.Member;
using Assignment1.Services.Rent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1Web.Views.Rent
{
    public partial class Rent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindMember();
                if (Request.QueryString["id"] != null)
                {
                    hdRentId.Value = Request.QueryString["id"].ToString();
                    BindData();
                    btnSave.Text = "Update";
                }
                btnSave.Enabled = true;

            }
        }

        void BindMember()
        {
            RentService rentService = new RentService();
            DataTable dt = rentService.GetMember();
            ddlMemberName.DataSource = dt;
            ddlMemberName.DataValueField = "MemberId";
            ddlMemberName.DataTextField = "FullName";
            ddlMemberName.DataBind();
        }
        void BindData()
        {
            RentService rentService = new RentService();
            DataTable dt = rentService.Get(Convert.ToInt32(hdRentId.Value));
            if (dt.Rows.Count > 0)
            {
                txtRentName.Text = dt.Rows[0]["MovieRented"].ToString();
                ddlMemberName.DataValueField = dt.Rows[0]["MemberId"].ToString();
                ddlMemberName.DataTextField = dt.Rows[0]["FullName"].ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AddorUpdate();
        }

        void AddorUpdate()
        {
            RentService rentService = new RentService();
            RentEntity rentEntity = CreateData();
            bool success = false;
            if (hdRentId.Value == "0")
            {
                    success = rentService.Insert(rentEntity);
                
            }
            else
            {
                success = rentService.Update(rentEntity);
            }

            if (success)
            {
                Response.Redirect("~/Views/Rent/RentList.aspx");
            }
        }

        public RentEntity CreateData()
        {
            RentEntity rentEntity = new RentEntity();
            rentEntity.rentedid = Convert.ToInt32(hdRentId.Value);
            rentEntity.movierented = txtRentName.Text;
            rentEntity.memberid = Convert.ToInt32(ddlMemberName.SelectedValue);
            return rentEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Rent/RentList.aspx");
        }
    }
}