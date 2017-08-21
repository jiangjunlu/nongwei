using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.zixun
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ZiXun ad = new Admin.ZiXun();
            try
            {
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                // "../uploadimg/" + file.FileName, "../uploadimg/" + file.FileName
                ad.updatezixun(Request["zixunid"], Request["title"], Request["keyword"], Request["type"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch
            {
                ad.updatezixun(Request["zixunid"], Request["title"], Request["type"],Microsoft.JScript.GlobalObject.unescape(Request["content"]),System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["keyword"]);

            }
        }
    }
}