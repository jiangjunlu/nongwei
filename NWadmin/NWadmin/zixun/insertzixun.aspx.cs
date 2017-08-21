using System;
using System.Collections.Generic;
using Microsoft.JScript;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.zixun
{
    public partial class insertzixun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            Admin.ZiXun admin= new Admin.ZiXun();
            try
            {
                admin.insertzixun(Request["title"], Request["keyword"],Request["type"], Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));

               // ad.insertyaowen( Request["title"], Request["keyword"],
                 //   Request["type"],Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                 //   "../uploadimg/" + file.FileName, "123",
                //   "../uploadimg/" + file.FileName);
           }
            catch
            {
                admin.insertzixun(Request["title"], Request["keyworld"], Request["type"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
                //ad.insertyaowen(Request["title"], Request["keyword"],
                    //    Request["type"],Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    //    " ", "123",
                    //   "123" + "");
            }
        }
    }
}