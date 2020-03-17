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
    public partial class LoginPage : System.Web.UI.Page
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
            adp.SelectCommand.Parameters.AddWithValue("@U", txtUsername.Text);
            adp.SelectCommand.Parameters.AddWithValue("@P", txtPassword.Text);
            SqlParameter p = new SqlParameter("@C", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            if (p.Value.ToString() == "1")
            {
                Session["User"] = txtUsername.Text;
                Response.Redirect("Addemp.aspx");
            }
            else
            {
                LblMessage.Text = "Invalid Credentials";
                txtUsername.Text = "";
                txtUsername.Focus();
            }

        }
    }
}