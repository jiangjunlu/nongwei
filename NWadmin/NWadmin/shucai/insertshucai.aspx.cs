using System;
using System.Collections.Generic;
using Microsoft.JScript;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.shucai
{
    public partial class insertshucai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShuCai admin = new Admin.ShuCai();
            //try
            //{
               admin.insertshucai(Request["title"],Request["type"], Request["keyword"],
                   Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
              
               //HttpPostedFile file = Request.Files["file"];
               // file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
               //  admin.insertshucai( Request["title"], Request["type"], Request["keyword"], 
               //      Microsoft.JScript.GlobalObject.unescape( Request["content"]),
               //      System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), 
               //      Request["author"],"../uploadimg/" + file.FileName);
            //}
            //catch
            //{
            //   admin.insertshucai(Request["title"],Request["type"], Request["keyworld"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
            //   //admin.insertshucai(Request["title"], Request["type"], Request["keyword"],
            //   //    Microsoft.JScript.GlobalObject.unescape(Request["content"]),
            //   //    System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
            //   //    Request["author"], Request["oldpath"]
            //      );
            //}
        }
    }
}