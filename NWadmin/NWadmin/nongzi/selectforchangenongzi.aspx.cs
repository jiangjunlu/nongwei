using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.nongzi
{
    public partial class selectforchangenongzi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.NongZi ad = new Admin.NongZi();

            DataSet ds = ad.selectforchangenongzi(Request["id"]);
            Response.Write(JsonTool.DataTableToJson("0", ds.Tables[0]));

        }
    }
}