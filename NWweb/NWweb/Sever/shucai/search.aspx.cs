using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWweb.Sever.shucai
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShuCai ad = new Admin.ShuCai();
            string size = "1";
            DataSet ds = new DataSet();
            ds = ad.search(Request["accord"], int.Parse(Request["flag"]), int.Parse(Request["index"]), ref size);
            Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
        }
    }
}