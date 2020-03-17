using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        ADODBEntities1 A = null;
        private void bind()
        {
            A = new ADODBEntities1();
            var v = from O in A.v5
                    select O;
            GridView1.DataSource = v.ToList();
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bind();
        }
    }
}