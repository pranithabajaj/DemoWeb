using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class CookieEx2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //fetch the data from cookies
            string s = Request.Cookies["User"].Value;
            Response.Write(s);
            string s1 = Request.Cookies["User1"].Value;
            Response.Write(s1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CookieEx3.aspx");
        }
    }
}