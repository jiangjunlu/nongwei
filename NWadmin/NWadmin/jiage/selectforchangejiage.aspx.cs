using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.jiage
{
    public partial class selectforchangejiage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.JiaGe ad = new Admin.JiaGe();

            DataSet ds = ad.selectforchangejiage(Request["id"]);
            Response.Write(JsonTool.DataTableToJson("0", ds.Tables[0]));
        }
    }
}