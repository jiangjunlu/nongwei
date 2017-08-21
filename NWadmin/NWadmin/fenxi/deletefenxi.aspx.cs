using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.fenxi
{
    public partial class deletefenxi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.FenXi ad = new Admin.FenXi();
            try
            {
                ad.deletefenxi(int.Parse(Request["id"]));
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}