using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Tutorial10
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnForget_Click(object sender, EventArgs e)
        {
            txtGmail.Visible = true;
            btnSend.Visible = true;
        }

     
        protected void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient("smtp.mailtrap.io", 2525);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("a70f64ecb948dd", "9c05f17a0375b0");
            MailMessage message = new MailMessage();
            message.From = new MailAddress("kaykhinepyonewai@gmail.com");
            message.IsBodyHtml = true;
            message.Subject = "Password reset link";
            //message.Body = "Please <a href=\"http://localhost:62093/ResetPassword.aspx\">Password reset link</a>";
            message.Body = "<html><head><title>PasswordResetPage</title><h1 style='text-align:center;color:#56b880'>Please Click Below Link For Reset</h1><a style='margin-left:30px;color:#56b880;margin-top:20px;font-size:16px' href=\"http://localhost:62093/ResetPassword.aspx\">Password reset link</a><body></html> ";
            message.To.Add(txtGmail.Text.ToString());
            try
            {
                smtp.Send(message);
                Response.Write("<script>alert('Reset Link is reached to your Gamil,Please Check It....') </script>");
            }
            catch (SmtpException ex)
            {
                lblMsg.Text = "Error" + ex.Message;
            }
        }
    }
}