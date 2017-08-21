using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.fenxi
{
    public partial class searchfenxi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.FenXi ad = new Admin.FenXi();
            string size = "1";
            string response = "";
            DataSet ds = new DataSet();
            if (Request["flag"] == "0")
            {//进行题目模糊化查找
                ds = ad.searchfenxi(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            else
            {//进行关键词模糊化查找
                // ds = ad.searchyaowen2(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                ds = ad.searchfenxi2(Request["accord"], 1, 1, ref size);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            Response.Write(response);
        }
    }
}