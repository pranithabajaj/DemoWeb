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
    public partial class Updateemp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon1"].ToString());
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_UpdateDept", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEno.Text));
            
            adp.SelectCommand.Parameters.AddWithValue("@J", txtJob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@M", int.Parse(txtMgr.Text));
            
            adp.SelectCommand.Parameters.AddWithValue("@S", int.Parse(txtSal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@C", int.Parse(txtComm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Dno", int.Parse(txtDno.Text));
            SqlParameter p = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            LblMsg.Text = p.Value.ToString();
        }
    }
}