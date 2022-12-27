using Assignment1.Entities.Rent;
using Assignment1.Services.Rent;
using System;
using System.Data;

namespace Assignment1Web.Views.Rent
{
    public partial class Rent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    hdRentId.Value = Request.QueryString["id"].ToString();
                    BindData();
                    btnSave.Text = "Update";
                }
                btnSave.Enabled = true;

            }
        }

        void BindData()
        {
            RentService rentService = new RentService();
            DataTable dt = rentService.Get(Convert.ToInt32(hdRentId.Value));
            if (dt.Rows.Count > 0)
            {
                txtRentName.Text = dt.Rows[0]["MovieRented"].ToString();
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
                int count = 0;
                count = rentService.Count(rentEntity);
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


                    success = rentService.Insert(rentEntity);

            }
                btnSave.Enabled = true;
                txtRentName.Text = "";

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
            rentEntity.RentedId = Convert.ToInt32(hdRentId.Value);
            rentEntity.MovieRented = txtRentName.Text;
            return rentEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Rent/RentList.aspx");
        }
    }
}