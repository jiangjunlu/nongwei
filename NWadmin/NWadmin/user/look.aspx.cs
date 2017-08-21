using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.user
{
    public partial class look : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.User ad = new Admin.User();
            int id = int.Parse(Request["id"]);
            Response.Write(ad.lookuser(int.Parse(Request["id"])).Tables[0].Rows[0][0].ToString());
        }
    }
}