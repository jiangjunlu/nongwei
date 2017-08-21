using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.shucai
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShuCai ad = new Admin.ShuCai();
            try
            {
                HttpPostedFile file = Request.Files["file"];
                file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                ad.updateshucai(int.Parse(Request["shucaiid"]), Request["title"],Request["type"], Request["keyword"], 
                    Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                   Request["author"]);
            }
            catch
            {
                ad.updateshucai(int.Parse(Request["shucaiid"]), Request["title"],Request["type"], Request["keyword"],
                    Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                    System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),Request["author"]);

            }
        }
    }
}