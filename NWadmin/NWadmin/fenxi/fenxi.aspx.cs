﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.fenxi
{
    public partial class fenxi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.FenXi admin = new Admin.FenXi();
            string size = "1";
            DataSet ds = new DataSet();
            try
            {
                ds = admin.selectfenxi(int.Parse(Request["index"]), ref size);
                Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
            }
           catch (Exception ex)
            {

                //Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
               Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
            }
        }
    }
}