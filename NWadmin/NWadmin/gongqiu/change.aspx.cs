using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.gongqiu
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.GongQiu ad = new Admin.GongQiu();
            try
            {
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                // "../uploadimg/" + file.FileName, "../uploadimg/" + file.FileName
                ad.updategongqiu(int.Parse(Request["gongqiuid"]), Request["title"],Request["type"], Request["name"], Request["phone"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch
            {
                ad.updategongqiu(int.Parse(Request["gongqiuid"]), Request["title"], Request["type"], Request["name"], Request["phone"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                 System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            }
        }
    }
}