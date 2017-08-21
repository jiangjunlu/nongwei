using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.fenxi
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.FenXi ad = new Admin.FenXi();
            try
            {
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                // "../uploadimg/" + file.FileName, "../uploadimg/" + file.FileName
                ad.updatefenxi(Request["fenxiid"], Request["title"], Request["type"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch
            {
                ad.updatefenxi(Request["fenxiid"], Request["title"], Request["type"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                    System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            }
        }
    }
}