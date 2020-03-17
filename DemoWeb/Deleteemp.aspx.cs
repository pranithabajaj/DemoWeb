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
    public partial class Deleteemp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon1"].ToString());
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_deleteEmp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEno.Text));
            SqlParameter p = new SqlParameter("@R", SqlDbType.NVarChar, 200);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            LblMsg.Text = p.Value.ToString();
        }
    }
}