using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.liangshi
{
    public partial class look : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.LiangShi ad = new Admin.LiangShi();
            int id = int.Parse(Request["id"]);
            Response.Write(ad.lookliangshi(int.Parse(Request["id"])).Tables[0].Rows[0][0].ToString());
        }
    }
}