﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class ViewStateEx1 : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            //ViewState["V"] = true;
            if (ViewState["V"] == null)
                ViewState["V"] = 10;
            else
                ViewState["V"] = (int)ViewState["V"] + 1;
            //i = 10;
            if (i != 0)
                i = 10;
            else
                i++;
            TextBox1.Text = (++i).ToString();
            TextBox2.Text = ViewState["V"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = (++i).ToString();
            //TextBox2.Text = ViewState["V"].ToString();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStateEx2.aspx");
        }
    }
}