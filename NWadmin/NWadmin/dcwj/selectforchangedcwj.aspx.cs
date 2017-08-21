using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwj
{
    public partial class selectforchangedcwj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJ ad = new Admin.DCWJ();

            DataSet ds = ad.selectforchangedcwj(Request["id"]);
            Response.Write(JsonTool.DataTableToJson("0", ds.Tables[0]));
        }
    }
}