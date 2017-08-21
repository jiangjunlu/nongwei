using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.liangshi
{
    public partial class selectforchangeliangshi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.LiangShi ad = new Admin.LiangShi();

            DataSet ds = ad.selectforchangeliangshi(Request["id"]);
            Response.Write(JsonTool.DataTableToJson("0", ds.Tables[0]));
        }
    }
}