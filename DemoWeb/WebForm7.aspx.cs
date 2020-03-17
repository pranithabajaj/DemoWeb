using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        ADODBEntities1 A = null;
        private void bind()
        {
            A = new ADODBEntities1();
            var v = from O in A.v5
                    select O;
            FormView1.DataSource = v.ToList();
            FormView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
            //GridView1.DataSource = v.ToList();
            //GridView1.DataBind();
            //dview.DataSource = v.ToList();
            //dview.DataBind();
            
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            bind();
        }
    }
}