using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DemoWeb
{
   
    public partial class Addemp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon1"].ToString());
            //Label1.Text=Response.Write(Session["User"].ToString());
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_InsertEmp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Eno",int.Parse(txtEno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@En", txtEname.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Job", txtJob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Mgr", int.Parse(txtMgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Hdate", txtHdate.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Sal", int.Parse(txtSal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Comm", int.Parse(txtComm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Dno", int.Parse(txtDno.Text));
            SqlParameter p = new SqlParameter("@R", SqlDbType.NVarChar,200);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            LblMsg.Text = p.Value.ToString();
        }
    }
}