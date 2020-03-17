using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class Update1 : System.Web.UI.Page
    {
        TestEntities T = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            T = new TestEntities();
        }

        protected void txtEno_TextChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEno.Text);
            var E = from E1 in T.EMPDATAs
                    where E1.EMPNO==eno
                    select E1;
            EMPDATA emp = E.First();//if query results in multiple records assign to list else assign it to a single object
            //List<EMPDATA> L = E.ToList(); returns multiple records
            txtEname.Text = emp.ENAME;
            txtJob.Text = emp.JOB;
            txtMgr.Text = emp.MGR.ToString();
            txtHdate.Text = DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");
            txtSal.Text = emp.SAL.ToString();
            txtComm.Text = emp.COMM.ToString();
            txtDno.Text = emp.DEPTNO.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEno.Text);
            var E = from E1 in T.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            int c = 0;
            bool b = int.TryParse(txtComm.Text, out c);
            emp.JOB = txtJob.Text;
            emp.MGR = int.Parse(txtMgr.Text);
            emp.SAL = int.Parse(txtSal.Text);
            if(c!=0)
                emp.COMM = c;
            emp.DEPTNO = int.Parse(txtDno.Text);
            T.SaveChanges();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEno.Text);
            var E = from E1 in T.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            T.EMPDATAs.Remove(emp);
            T.SaveChanges();
        }
    }
}