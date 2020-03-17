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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlcon"].ToString());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_validateLogin", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@U", txtUname.Text);
            adp.SelectCommand.Parameters.AddWithValue("@P", txtPwd.Text);
            SqlParameter p = new SqlParameter("@C", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds,"L");
            if (p.Value.ToString() == "1")
            {
                Response.Cookies["Username"].Value = txtUname.Text;
                Response.Redirect("Addemp.aspx");
            }
            else
            {
                LblMsg.Text = "Invalid Credentials";
                txtUname.Text = "";
                txtUname.Focus();
            }

        }

        protected void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}