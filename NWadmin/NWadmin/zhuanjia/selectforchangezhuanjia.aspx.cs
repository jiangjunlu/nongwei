using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.zhuanjia
{
    public partial class selectforchangezhuanjia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ZhuanJia ad = new Admin.ZhuanJia();

            DataSet ds = ad.selectforchangezhuanjia(Request["id"]);
            Response.Write(JsonTool.DataTableToJson("0", ds.Tables[0]));
        }
    }
}