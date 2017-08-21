using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.jiance
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.JianCe ad = new Admin.JianCe();
            try
            {
                HttpPostedFile file = Request.Files["file"];
                file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                //"../uploadimg/" + file.FileName, 
                ad.updatejiance(Request["jianceid"], Request["type"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),/* "../uploadimg/" + file.FileName,*/
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),Request["zhouqi"]);
            }
            catch
            {
                ad.updatejiance(Request["jianceid"], Request["type"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),/* Request["oldpath"],*/
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),Request["zhouqi"]);
            }
        }
    }
}