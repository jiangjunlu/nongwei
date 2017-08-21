using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.nongzi
{
    public partial class deletenongzi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.NongZi ad = new Admin.NongZi();
            try
            {
                ad.deletenongzi(int.Parse(Request["id"]));
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
        }
    }
}