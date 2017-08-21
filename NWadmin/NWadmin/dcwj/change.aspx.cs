using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwj
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJ ad = new Admin.DCWJ();
            try
            {
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                // "../uploadimg/" + file.FileName, "../uploadimg/" + file.FileName
                ad.updatedcwj(Request["dcwjid"], Request["title"],  Microsoft.JScript.GlobalObject.unescape(Request["describe"]), Request["result"],
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch
            {
                ad.updatedcwj(Request["dcwjid"], Request["title"], Microsoft.JScript.GlobalObject.unescape(Request["describe"]), Request["keyword"] ,System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            }
        }
    }
}