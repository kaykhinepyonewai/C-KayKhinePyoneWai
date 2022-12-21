using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tutorial_8
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowData();
                btnInsert.Enabled = true;
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            CheckingName();
            con.Close();
            ShowData();
        }

        void CheckingName()
        {
            int count = 0;
            con.Open();
            string showt = "select COUNT(*) from Cats where Name=@name1";
            SqlCommand cmd = new SqlCommand(showt, con);
            cmd.Parameters.AddWithValue("@name1", txtName.Text.ToString());
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count>0)
            {
                btnInsert.Enabled = false;
                lbName.Visible = true;
            }
            else
            {
                string insertCats = "insert into [Cats] (Name) values (@name)";
                SqlCommand cmd1 = new SqlCommand(insertCats, con);
                cmd1.Parameters.AddWithValue("@name", txtName.Text.ToString());
                cmd1.ExecuteNonQuery();
                Response.Write("<script>alert('Successful Data Inserting') </script>");
                con.Close();
                btnInsert.Enabled = true;
                lbName.Visible = false;
            }

            btnInsert.Enabled = true;

        }
        void ShowData()
        {
            con.Open();
            string showData = "select * from Cats";
            SqlCommand cmd = new SqlCommand(showData, con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            if(dt.Rows.Count>0)
            {
                gvList.DataSource = dt;
                gvList.DataBind();
            }
            else
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                gvList.DataSource = dt;
                gvList.DataBind();
            }

            txtName.Text = "";
            con.Close();

        }

        protected void btnListForm_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataListForm.aspx");
        }

        protected void gvList_RowEditing(object sender, GridViewEditEventArgs e)
        {
            lbName.Visible = false;
            gvList.EditIndex = e.NewEditIndex;
            ShowData();
        }

        protected void gvList_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            lbName.Visible = false;
            int id = Convert.ToInt32(gvList.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)gvList.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            con.Open();

            string updateData = "update Cats set Name=@name where Id=@id";
            SqlCommand cmd = new SqlCommand(updateData, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Data has updated') </script>");
            con.Close();
            gvList.EditIndex = -1;
            ShowData();
        }

        protected void gvList_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            lbName.Visible = false;
            gvList.EditIndex = -1;
            ShowData();
        }

        protected void gvList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            lbName.Visible = false;
            con.Open();
            int id = Convert.ToInt32(gvList.DataKeys[e.RowIndex].Value.ToString());
            string deleteData = "delete from Cats where Id=@id";
            SqlCommand cmd = new SqlCommand(deleteData, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Response.Write("<script>confirm('Data has Deleted')</script>");
            con.Close();
            ShowData();
        }

        
    }
}