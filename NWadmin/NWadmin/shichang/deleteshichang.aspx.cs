using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.shichang
{
    public partial class deleteshichang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShiChang ad = new Admin.ShiChang();
            try
            {
                ad.deleteshichang(int.Parse(Request["id"]));
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}