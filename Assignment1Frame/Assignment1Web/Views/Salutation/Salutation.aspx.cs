using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment1.Services.Salutation;
using Assignment1.Entities.Salutation;
using System.Data;

namespace Assignment1Web.Views.Salutation
{
    public partial class Salutation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    hdSalutationId.Value = Request.QueryString["id"].ToString();
                    BindData();
                    btnSave.Text = "Update";
                }
                btnSave.Enabled = true;
                txtSalutationName.Text = "";
            }
        }

        void BindData()
        {
            SalutaionService salutaionService = new SalutaionService();
            DataTable dt = salutaionService.Get(Convert.ToInt32(hdSalutationId.Value));
            if(dt.Rows.Count>0)
            {
               
                txtSalutationName.Text = dt.Rows[0]["Salutation"].ToString();
            }

          
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AddorUpdate();
        }

        void AddorUpdate()
        {
            SalutaionService salutaionService = new SalutaionService();
            SalutationEntity salutationEntity = CreateData();

            bool success = false;
            if(hdSalutationId.Value == "0")
            {
                int count = 0;
                count = salutaionService.Count(salutationEntity);
                if(count > 0)
                {
                    btnSave.Enabled = false;
                    lblMessage.Text = "Name is Already Exit......";
                    lblMessage.Visible = true;
                }
                else
                {
                    btnSave.Enabled = true;
                    lblMessage.Visible = true;
                    success = salutaionService.Insert(salutationEntity);
                }

                btnSave.Enabled = true;
                txtSalutationName.Text = "";

            }
            else
            {
                success = salutaionService.Update(salutationEntity);
            }

            if (success)
            {
                Response.Redirect("~/Views/Salutation/SalutationList.aspx");
            }
        }

        public SalutationEntity CreateData()
        {
            SalutationEntity salutationEntity = new SalutationEntity();
            salutationEntity.salutationid = Convert.ToInt32(hdSalutationId.Value);
            salutationEntity.salutation = txtSalutationName.Text;

            return salutationEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Salutation/SalutationList.aspx");
        }
    }
}