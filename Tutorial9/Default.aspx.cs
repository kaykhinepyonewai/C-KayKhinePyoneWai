using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Data;
using OfficeOpenXml;
using System.Web.Services.Discovery;
using System.Net;

namespace Tutorial9
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string FileExt = System.IO.Path.GetExtension(FileUploadTo.PostedFile.FileName);
            if (FileExt == ".xls" || FileExt == ".xlsx")
            {
                lblMsg.Visible = false;
                ExcelUpload();
            }
            else if(FileExt == ".csv")
            {
                lblMsg.Visible = false;
                CsvUpload();
            }
            else if(FileExt == ".txt")
            {
                lblMsg.Visible = false;
                TxtUpload();
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Please Choose Text file || Excel File || CSV File";
            }
        }

        void TxtUpload()
        {
          
            string txtPath = Server.MapPath("~/Datas/") + Path.GetFileName(FileUploadTo.PostedFile.FileName);
            FileUploadTo.SaveAs(txtPath);

          
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5]
            {
            new DataColumn("Id", typeof(int)),
            new DataColumn("Name", typeof(string)),
            new DataColumn("Address",typeof(string)),
            new DataColumn("PhoneNo",typeof(string)),
            new DataColumn("GmailAddress",typeof(string)),
            });


            string csvData = File.ReadAllText(txtPath);

           
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    dt.Rows.Add();
                    int i = 0;
                    foreach (string cell in row.Split(' '))
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell;
                        i++;
                    }
                }
            }
            gvList.DataSource = dt;
            gvList.DataBind();
        }

         void CsvUpload()
        {
            string csvPath = Server.MapPath("~/Datas/") + Path.GetFileName(FileUploadTo.PostedFile.FileName);
            FileUploadTo.SaveAs(csvPath);
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5]
            {
            new DataColumn("Id", typeof(int)),
            new DataColumn("Name", typeof(string)),
            new DataColumn("Address",typeof(string)),
            new DataColumn("PhoneNo",typeof(string)),
            new DataColumn("GmailAddress",typeof(string)),
            });

            string csvData = File.ReadAllText(csvPath);
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    dt.Rows.Add();
                    int i = 0;
                    foreach (string cell in row.Split(','))
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell;
                        i++;
                    }
                }
            }
            gvList.DataSource = dt;
            gvList.DataBind();
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
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = "Please upload only Excel";
                }
                else
                {
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


                                    for (int col = startCell.Column; col <= endCell.Column; col++)
                                    {
                                        object col1Header1 = worksheet.Cells[1, col].Value;
                                        dt.Columns.Add("" + col1Header1 + "");
                                    }
                                    for (int row = startCell.Row + 1; row <= endCell.Row + 1; row++)
                                    {
                                        DataRow dr = dt.NewRow();
                                        int x = 0;
                                        for (int col = startCell.Column; col <= endCell.Column; col++)
                                        {
                                            dr[x++] = worksheet.Cells[row, col].Value;
                                        }
                                        dt.Rows.Add(dr);
                                        gvList.DataSource = dt;
                                        gvList.DataBind();
                                    }
                                }

                            }

                        }

                    }
                }
            }


        }
    }
    }
    
