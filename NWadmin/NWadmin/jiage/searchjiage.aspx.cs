using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.jiage
{
    public partial class searchjiage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.JiaGe ad = new Admin.JiaGe();
            string size = "1";
            string response = "";
            DataSet ds = new DataSet();
            if (Request["flag"] == "0")
            {
                ds = ad.searchjiage(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            else
            {
                // ds = ad.searchyaowen2(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                ds = ad.searchjiage2(Request["accord"], 1, 1, ref size);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            Response.Write(response);
        }
    }
}