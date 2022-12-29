using Assignment2.Entities.Member;
using Assignment2.Services.Member;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Web.UI.WebControls;
using System.Web;

namespace Assignment2Web.Views.Member
{
    public partial class ExoprtList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkbtnImport_Click(object sender, EventArgs e)
        {
            ExcelUpload();
           
        }

        void ExcelUpload()
        {
            string FilePath = ConfigurationManager.AppSettings["FilePath"].ToString();
            string filename = string.Empty;
            if (FileUploadTo.HasFile)
            {

                string[] allowdFile = { ".xls", ".xlsx" };
                string FileExt = System.IO.Path.GetExtension(FileUploadTo.PostedFile.FileName);
                bool isValidFile = allowdFile.Contains(FileExt);
                if (!isValidFile)
                {
                    lblMsg.Visible = true;
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = "Please upload only Excel";
                }
                else
                {
                    //lblMsg.Visible = false;
                    int FileSize = FileUploadTo.PostedFile.ContentLength;
                    if (FileSize <= 1048576)
                    {
                        filename = Path.GetFileName(Server.MapPath(FileUploadTo.FileName));
                        FileUploadTo.SaveAs(Server.MapPath(FilePath) + filename);
                        string filePath = Server.MapPath(FilePath) + filename;

                        DataTable dt = new DataTable();
                        var existingFile = new FileInfo(filePath);
                        using (var package = new ExcelPackage(existingFile))
                        {
                            ExcelWorkbook workBook = package.Workbook;
                            if (workBook != null)
                            {
                                if (workBook.Worksheets.Count > 0)
                                {
                                    ExcelWorksheet worksheet = workBook.Worksheets.First();
                                    ExcelCellAddress startCell = worksheet.Dimension.Start;
                                    ExcelCellAddress endCell = worksheet.Dimension.End;

                                    MemberEntity memberEntity = new MemberEntity();
                                    MemberService memberService = new MemberService();
                                    for (int i = 2; i <= endCell.Row; i++)
                                    {
                                        memberEntity.FullName = Convert.ToString(worksheet.Cells[i, 1].Value);
                                        memberEntity.Address = Convert.ToString(worksheet.Cells[i, 2].Value);

                                        string MovieRented = Convert.ToString(worksheet.Cells[i, 3].Value);
                                        int RentedId = memberService.TakeRentedId(MovieRented);
                                        memberEntity.RentedId = RentedId;

                                        string salutaionName = Convert.ToString(worksheet.Cells[i, 4].Value);
                                        int SalutationId = memberService.TakeSalutationId(salutaionName);
                                        memberEntity.SalutationId = SalutationId;
                                        memberService.Insert(memberEntity);
                                    }
                                }
                            }
                        }
                    }
                    Response.Redirect("~/Views/Member/MemberList.aspx");
                }
            }
        }

    }
}
