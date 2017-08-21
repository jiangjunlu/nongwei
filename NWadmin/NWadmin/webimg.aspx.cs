using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin
{
    public partial class webimg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpPostedFile file0 = Request.Files["lb0"];
            HttpPostedFile file1 = Request.Files["lb1"];
            HttpPostedFile file2 = Request.Files["lb2"];
            HttpPostedFile file3 = Request.Files["lb3"];
            if (file0 != null)
            {
                file0.SaveAs(Server.MapPath("WebImages/lb0.png"));
            }
            if (file1 != null)
            {
                file1.SaveAs(Server.MapPath("WebImages/lb1.png"));
            }
            if (file2 != null)
            {
                file2.SaveAs(Server.MapPath("WebImages/lb2.png"));
            }
            if (file3 != null)
            {
                file3.SaveAs(Server.MapPath("WebImages/lb3.png"));
            }
        }
    }
}