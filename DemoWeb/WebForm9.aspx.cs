﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime tday = DateTime.Today;
            DateTime dob = DateTime.Parse(Txtdob.Text);
            int age=(int)(tday.Subtract(dob).TotalDays)/365;
            if(age>=21 && age<=58)
                args.IsValid = true;
            else
                args.IsValid = false;
        }
    }
}