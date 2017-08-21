using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwjxuanxiang
{
    public partial class selectforchangetitle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJXuanXiang ad = new Admin.DCWJXuanXiang();
            DataSet dss = ad.getTitle(int.Parse(Request["titleid"]));
            Response.Write(JsonTool.DataTableToJson("0", dss.Tables[0]));
        }
    }
}