using Assignment2.Services.Member;
using Assignment2.Entities.Member;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
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

        //void ExcelUpload()
        //{
        //    string FilePath = ConfigurationManager.AppSettings["FilePath"].ToString();
        //    string filename = string.Empty;
        //    if (FileUploadTo.HasFile)
        //    {

        //        string[] allowdFile = { ".xls", ".xlsx" };
        //        string FileExt = System.IO.Path.GetExtension(FileUploadTo.PostedFile.FileName);
        //        bool isValidFile = allowdFile.Contains(FileExt);
        //        if (!isValidFile)
        //        {
        //            lblMsg.Visible = true;
        //            lblMsg.ForeColor = System.Drawing.Color.Red;
        //            lblMsg.Text = "Please upload only Excel";
        //        }
        //        else
        //        {
        //            //lblMsg.Visible = false;
        //            int FileSize = FileUploadTo.PostedFile.ContentLength;
        //            if (FileSize <= 1048576)
        //            {
        //                filename = Path.GetFileName(Server.MapPath(FileUploadTo.FileName));
        //                FileUploadTo.SaveAs(Server.MapPath(FilePath) + filename);
        //                string filePath = Server.MapPath(FilePath) + filename;

        //                DataTable dt = new DataTable();
        //                var existingFile = new FileInfo(filePath);
        //                using (var package = new ExcelPackage(existingFile))
        //                {
        //                    ExcelWorkbook workBook = package.Workbook;
        //                    if (workBook != null)
        //                    {
        //                        if (workBook.Worksheets.Count > 0)
        //                        {
        //                            ExcelWorksheet worksheet = workBook.Worksheets.First();
        //                            ExcelCellAddress startCell = worksheet.Dimension.Start;
        //                            ExcelCellAddress endCell = worksheet.Dimension.End;

        //                            MemberEntity memberEntity = new MemberEntity();
        //                            MemberService memberService = new MemberService();
        //                            for (int i = 2; i <= endCell.Row; i++)
        //                            {
        //                                memberEntity.FullName = Convert.ToString(worksheet.Cells[i, 1].Value);
        //                                memberEntity.Address = Convert.ToString(worksheet.Cells[i, 2].Value);

        //                                string MovieRented = Convert.ToString(worksheet.Cells[i, 3].Value);
        //                                int RentedId = memberService.TakeRentedId(MovieRented);
        //                                memberEntity.RentedId = RentedId;

        //                                string salutaionName = Convert.ToString(worksheet.Cells[i, 4].Value);
        //                                int SalutationId= memberService.TakeSalutationId(salutaionName);
        //                                memberEntity.SalutationId = SalutationId;
        //                                memberService.Insert(memberEntity);
        //                            }
        //                            BindData();

        //                        }
        //                      }
        //                    }
        //                }
        //            }
        //        }
        //    }
    }
    }
