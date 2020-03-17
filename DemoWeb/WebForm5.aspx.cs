using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        TestEntities T = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            T = new TestEntities();
        }
        //inserting values without stored procedures(we shld use try and catch)
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                EMPDATA E = new EMPDATA();
                E.EMPNO = int.Parse(txtEno.Text);
                E.ENAME = txtEname.Text;
                E.JOB = txtJob.Text;
                E.MGR = int.Parse(txtMgr.Text);
                E.HIREDATE = DateTime.Parse(txtHdate.Text);
                E.SAL = int.Parse(txtSal.Text);
                E.COMM = int.Parse(txtComm.Text);
                E.DEPTNO = int.Parse(txtDno.Text);
                T.EMPDATAs.Add(E);
                T.SaveChanges();
            }
            catch(DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                    LblMsg.Text = "No duplicate empno";
                else if(ex.Message.Contains("FK__EMPDATA__DEPTNO__5441852A"))
                    LblMsg.Text = "No deptno";
                else
                    LblMsg.Text = ex.Message;
            }
        }
        //inserting values with the help of stored procedures
        protected void Button1_Click(object sender, EventArgs e)
        {
            ObjectParameter ob = new ObjectParameter("R",typeof(string));
            T.sp_InsertEmp(int.Parse(txtEno.Text), txtEname.Text, txtJob.Text, int.Parse(txtMgr.Text), 
                DateTime.Parse(txtHdate.Text), int.Parse(txtSal.Text), int.Parse(txtComm.Text), 
                int.Parse(txtDno.Text),ob);
            LblMsg.Text = ob.Value.ToString();
        }
    }
}