using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon1"].ToString());
            if (!IsPostBack)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptno.Enabled = false;
                adp = new SqlDataAdapter("sp_ExtractDept", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "D");
                ddlDeptno.DataSource = ds.Tables["D"];
                ddlDeptno.DataTextField = "Dname";
                ddlDeptno.DataValueField = "deptno";
                ddlDeptno.DataBind();
            }
        }

        protected void rdbHiredate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                txtStart.Enabled = true;
                txtEnd.Enabled = true;
                ddlDeptno.Enabled = false;
            }
        }

        protected void rdbDeptno_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDeptno.Checked)
            {
                txtStart.Enabled = false;
                txtEnd.Enabled = false;
                ddlDeptno.Enabled = true;
            }
        }

        protected void btnExtract_Click(object sender, EventArgs e)
        {
            if (rdbHiredate.Checked)
            {
                adp = new SqlDataAdapter("sp_ExtractDate", con);
                
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@Sdate", txtStart.Text);
                adp.SelectCommand.Parameters.AddWithValue("@Edate", txtEnd.Text);
                DataSet ds = new DataSet();
                adp.Fill(ds, "E");
                gvData.DataSource = ds.Tables["E"];
                gvData.DataBind();
            }
            else if(rdbDeptno.Checked)
            {
                adp = new SqlDataAdapter("sp_getDeptDetails", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@dno", ddlDeptno.SelectedValue);
                DataSet ds = new DataSet();
                adp.Fill(ds, "E");
                gvData.DataSource = ds.Tables["E"];
                gvData.DataBind();
                ddlDeptno.Enabled = true;
            }
        }
    }
}