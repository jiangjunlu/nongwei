using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.shucai
{
    public partial class searchshucai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShuCai ad = new Admin.ShuCai();
            string size = "1";
            string response = "";
            DataSet ds = new DataSet();
            if (Request["flag"] == "0")
            {
                ds = ad.searchshucai(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            else
            {
                // ds = ad.searchyaowen2(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                ds = ad.searchshucai2(Request["accord"], 1, 1, ref size);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            Response.Write(response);
        }
    }
}