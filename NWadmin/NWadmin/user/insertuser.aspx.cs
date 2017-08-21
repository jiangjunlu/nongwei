using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.user
{
    public partial class insertuser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.User admin = new Admin.User();
            try
            {
                admin.insertuser(Request["name"], Request["pass"], Request["realname"], Request["phone"], System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch 
            {
                admin.insertuser(Request["name"], Request["pass"], Request["realname"], Request["phone"], System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            }
    }
}