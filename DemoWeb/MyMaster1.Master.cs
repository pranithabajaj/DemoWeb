using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class MyMaster1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.Cookies["Username"] == null)
            //    Response.Redirect("Login.aspx");
            //else
            //    Label1.Text = "Welcome " + Request.Cookies["Username"].Value;

            //if we are running same master page before and after login then
            string S = Path.GetFileName(Request.Path);
            if (S != "LoginPage.aspx")
            {
                if (Session["User"] == null)
                    Response.Redirect("LoginPage.aspx");
                else
                    LblMsg.Text = "Welcome " + Session["User"].ToString();
            }
        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //if (Request.Cookies["Username"] != null)
            //{
            //    //Response.Cookies["Username"].Expires = DateTime.Now.AddSeconds(1);
            //    HttpCookie aCookie = HttpContext.Current.Request.Cookies["Username"];
            //    aCookie.Expires = DateTime.Now.AddSeconds(1);
            //    aCookie.Value = "";
            //    HttpContext.Current.Response.Cookies.Add(aCookie);
            //    Response.Redirect("Login.aspx");

            //}
            if (Session["E"] != null)
            {
                Session.Abandon();
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}