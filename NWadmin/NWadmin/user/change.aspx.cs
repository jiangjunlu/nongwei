using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.user
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.User ad = new Admin.User();
            try
            {
                ad.updateuser(Request["userid"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),Request["type"],Request["realname"],Request["phone"]);
            }
            catch
            {
                ad.updateuser(Request["userid"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),Request["type"], Request["realname"], Request["phone"]);

            }
        }
    }
}