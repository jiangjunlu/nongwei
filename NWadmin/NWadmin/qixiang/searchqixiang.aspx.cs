using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.qixiang
{
    public partial class searchqixiang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.QiXiang ad = new Admin.QiXiang();
            string size = "1";
            string response = "";
            DataSet ds = new DataSet();
            if (Request["flag"] == "0")
            {
                ds = ad.searchqixiang( int.Parse(Request["index"]),int.Parse(Request["flag"]),  ref size, Request["accord"]);
                response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            else
            {
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)"));
                //// ds = ad.searchyaowen2(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
                //ds = ad.searchqixiang2( 1, 1, ref size,Request["accord"]);
                //response = JsonTool.DataTableToJson(size, ds.Tables[0]);
            }
            Response.Write(response);
        }
    }
}