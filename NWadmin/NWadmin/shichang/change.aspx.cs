using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.shichang
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShiChang ad = new Admin.ShiChang();
            try
            {
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                // "../uploadimg/" + file.FileName, "../uploadimg/" + file.FileName
                ad.updateshichang(Request["shichangid"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),Request["type"]);
            }
            catch
            {
                ad.updateshichang(Request["shichangid"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),Request["type"]);

            }
        }
    }
}