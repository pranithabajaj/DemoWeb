using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["E"] != null)
            {
                EMPDATA E = (EMPDATA)Session["E"];
                LblEmpno.Text = E.EMPNO.ToString();
                LblEname.Text = E.ENAME;
                LblJob.Text = E.JOB;
                LblHiredate.Text = E.HIREDATE.ToString();
                LblMgr.Text = E.MGR.ToString();
                LblSal.Text = E.SAL.ToString();
                LblComm.Text = E.COMM.ToString();
                LblDeptno.Text = E.DEPTNO.ToString();
                //to remove session variable
                Session.Remove("E");
                //Session["E"] = null;
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}