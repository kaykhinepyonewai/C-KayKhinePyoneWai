﻿using System;
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
                showData();
                btnInsert.Enabled = true;
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            checkingName();
            con.Close();
            showData();
        }

        void checkingName()
        {
            int count = 0;
            con.Open();
            string showt = "select COUNT(*) from cats where name=@name1";
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
                string insertCats = "insert into [cats] (name) values (@name)";
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
        void showData()
        {
            con.Open();
            string showData = "select * from cats";
            SqlCommand cmd = new SqlCommand(showData, con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            if(dt.Rows.Count>0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

            txtName.Text = "";
            con.Close();

        }

        protected void btnListForm_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataListForm.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }

       
    }
}