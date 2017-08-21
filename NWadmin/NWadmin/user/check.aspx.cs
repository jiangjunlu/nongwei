using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.user
{
    
    public partial class check : System.Web.UI.Page
    {
        public static string nameable;
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.User admin = new Admin.User();
            nameable = admin.checkname(Request["name"]);
            Response.Write(nameable);
        }
    }
}