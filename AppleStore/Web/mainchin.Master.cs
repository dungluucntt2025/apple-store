﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class mainchin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            if (Request.Cookies["ReturnURL"] != null)
            {
                Response.Cookies["ReturnURL"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("DangNhap.aspx");
        }
    }
}