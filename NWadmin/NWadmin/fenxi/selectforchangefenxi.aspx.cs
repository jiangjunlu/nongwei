using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.fenxi
{
    public partial class selectforchangefenxi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.FenXi ad = new Admin.FenXi();

            DataSet ds = ad.selectforchangefenxi(Request["id"]);
            Response.Write(JsonTool.DataTableToJson("0", ds.Tables[0]));
        }
    }
}