using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwjxuanxiang
{
    public partial class searchdcwjxuanxiang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJXuanXiang ad = new Admin.DCWJXuanXiang();
            string size = "1";
            string sizes = "1";
            string response = "";
            DataSet dss = new DataSet();
            DataSet ds = new DataSet();
            if (Request["flag"] == "0")
            {
                ds = ad.searchdcwjxuanxiang(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                dss = ad.selecttitle(int.Parse(Request["index"]), ref sizes);
                response = JsonTool.DataTableToJson(sizes, dss.Tables[0]).ToString() + ";" + JsonTool.DataTableToJson(size, ds.Tables[0]).ToString();
            }
            else
            {
                // ds = ad.searchyaowen2(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                ds = ad.searchdcwjxuanxiang2(Request["accord"], 1, 1, ref size);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            Response.Write(response);
        }
    }
}