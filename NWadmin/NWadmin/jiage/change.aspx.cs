using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.jiage
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.JiaGe ad = new Admin.JiaGe();
            try
            {
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                // "../uploadimg/" + file.FileName, "../uploadimg/" + file.FileName
                ad.updatejiage(Request["jiageid"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch
            {
                ad.updatejiage(Request["jiageid"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            }
        }
    }
}