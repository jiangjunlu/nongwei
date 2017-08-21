using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWweb.Sever.GONGQIU
{
    public partial class additems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.GongQiu ad = new Admin.GongQiu();
            ad.additems(Request["type"], Request["title"], Request["content"], Request["xingming"], Request["dianhua"], System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
        }
    }
}