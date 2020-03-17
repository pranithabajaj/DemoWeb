using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DemoWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sqlcon"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow r = ds.Tables["E"].NewRow();
            r[0] = int.Parse(txtEno.Text);
            r[1] = txtEname.Text;
            r[2] = txtJob.Text;
            r[3] = txtMgrid.Text;
            r[4] = DateTime.Parse(txtHdate.Text);
            r[5] = int.Parse(txtSal.Text);
            r[6] = int.Parse(txtComm.Text);
            r[7] = int.Parse(txtdno.Text);
            ds.Tables["E"].Rows.Add(r);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            adp.InsertCommand = cmd.GetInsertCommand();
            adp.Update(ds, "E");
            Response.Write("<script>alert('1 Row inserted')</script>");
        }
    }
}