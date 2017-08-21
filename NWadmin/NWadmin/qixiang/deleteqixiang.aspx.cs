using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.qixiang
{
    public partial class deleteqixiang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.QiXiang admin = new Admin.QiXiang();
            try
            {
                admin.deleteqixiang(int.Parse(Request["id"]));
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}