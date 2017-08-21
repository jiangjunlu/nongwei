using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.gongqiu
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.GongQiu ad = new Admin.GongQiu();
            ad.deletegongqiu(int.Parse(Request["id"]));
        }
    }
}