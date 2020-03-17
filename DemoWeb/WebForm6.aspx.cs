using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        TestEntities T = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            T = new TestEntities();
            if (!IsPostBack)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptno.Enabled = false;
                var E = from E1 in T.DEPTDATAs
                        select E1;
                List<DEPTDATA> L = E.ToList();
                ddlDeptno.DataSource = L;
                ddlDeptno.DataTextField = "Dname";
                ddlDeptno.DataValueField = "deptno";
                ddlDeptno.DataBind();
            }
        }

        protected void btnExtract_Click(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                DateTime sdate = DateTime.Parse(txtStart.Text);
                DateTime edate = DateTime.Parse(txtEnd.Text);
                var E = from E1 in T.EMPDATAs
                        where E1.HIREDATE >= sdate && E1.HIREDATE <= edate
                        select E1;
                List<EMPDATA> L = E.ToList();
                gvData.DataSource = L;
                gvData.DataBind();
            }
            else if (rdbDeptno.Checked)
            {
                int dno = int.Parse(ddlDeptno.SelectedValue);
                var E = from E1 in T.EMPDATAs
                        where E1.DEPTNO == dno
                        select E1;
                List<EMPDATA> L = E.ToList();
                gvData.DataSource = L;
                gvData.DataBind();
                ddlDeptno.Enabled = true;
            }
        }

        protected void rdbHiredate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                txtStart.Enabled = true;
                txtEnd.Enabled = true;
                ddlDeptno.SelectedValue = "-1";
                ddlDeptno.Enabled = false;
            }
        }

        protected void rdbDeptno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeptno.Checked)
            {
                txtStart.Text = "";
                txtEnd.Text = "";
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptno.Enabled = true;
            }
        }
    }
}