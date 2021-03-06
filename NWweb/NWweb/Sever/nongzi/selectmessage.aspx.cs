﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWweb.Sever.nongzi
{
    public partial class selectmessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.NongZi admin = new Admin.NongZi();
            string size = "1";
            DataSet ds = new DataSet();
            try
            {
                string title = Request["title"];
                ds = admin.looknongzi(title);
                Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
            }
            catch (Exception ex)
            {
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
            }
        }
    }
}