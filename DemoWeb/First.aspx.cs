using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class First : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            EMPDATA E = new EMPDATA();
            E.EMPNO = int.Parse(txtEno.Text);
            E.ENAME = txtEname.Text;
            E.JOB = txtJob.Text;
            E.HIREDATE = DateTime.Parse(txtHdate.Text);
            E.MGR = int.Parse(txtMgr.Text);
            E.SAL = int.Parse(txtSal.Text);
            E.COMM = int.Parse(txtComm.Text);
            E.DEPTNO = int.Parse(txtDno.Text);
            Session["E"] = E;
            Response.Redirect("Confirm.aspx");
        }
    }
}